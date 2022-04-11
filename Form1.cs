using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFileCheck
{
    public partial class Form1 : Form
    {
        private BackgroundWorker BackgroundWorker;
        private string nameFile;
        private List<FileData> fileDatas = new List<FileData>();
        private string pathJson;
        private List<FileData> sortedFileDatas = new List<FileData>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Browser_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                path.Text = dialog.SelectedPath;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathJson+@"\"+textBox1.Text + ".json") || textBox1.Text == String.Empty || pathJson == String.Empty)
            {
                MessageBox.Show("This file already exist. Please change your file name", "FileExist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label1.Text = "Working";
            progressBar1.Value = 0;
            nameFile = textBox1.Text;
            BackgroundWorker = new BackgroundWorker();
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.DoWork += FileDataWriter;
            BackgroundWorker.ProgressChanged += UpdateProgressBar;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            BackgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "Finish";
        }

        private void UpdateProgressBar(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void FileDataWriter(object sender, DoWorkEventArgs e)
        {
            try
            {
                Console.WriteLine("Start");
                List<FileData> fileDatas = new List<FileData>();
                GetFilesMultiThreading getFiles = new GetFilesMultiThreading();
                var links = getFiles.Start(path.Text);

                for (int i = 0; i < links.Count; i++)
                {
                    FileInfo fileInfo = new FileInfo(links[i]);
                    if (fileInfo.Exists)
                    {
                        fileDatas.Add(new FileData()
                        {
                            FileName = fileInfo.Name,
                            FilePath = fileInfo.FullName.Remove(0,4),
                            Size = fileInfo.Length,
                            DateLastestModif = fileInfo.LastWriteTime
                        });
                    }
                    else
                    {
                        Console.WriteLine("Skipped: " + links[i]);
                    }
                    int value = 100 * i / links.Count;
                    BackgroundWorker.ReportProgress(value);
                }
                Console.WriteLine("End");
                if (File.Exists(pathJson + @"\" + nameFile + ".json"))
                    throw new Exception("File exist");
                string jsonOK = JsonConvert.SerializeObject(fileDatas);
                File.WriteAllText(pathJson + @"\" + nameFile + ".json", jsonOK);
                BackgroundWorker.ReportProgress(100);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "FileExist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var files = Directory.GetFiles(dialog.SelectedPath,"*.json");
                    foreach (var file in files)
                    {
                        var fileStream = File.Open(file, FileMode.Open);
                        using (var Stream = new StreamReader(fileStream))
                        {
                            string json = Stream.ReadToEnd();
                            fileDatas.AddRange(JsonConvert.DeserializeObject<List<FileData>>(json));
                            
                        }
                        fileStream.Close();
                    }
                    dataGridView1.DataSource = new BindingList<FileData>(fileDatas);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SortLabel.Text = "Sorting ...";
            var temp2 = fileDatas.GroupBy(x => x.Size).Where(g => g.Count() > 1).SelectMany(g => g);
            var temp = temp2.OrderByDescending(f => f.Size).ThenBy(f => f.FileName);
            dataGridView1.DataSource = new BindingList<FileData>(temp.ToList());
            sortedFileDatas = temp.ToList();
            SortLabel.Text = "Sorted";
            
            Cursor = Cursors.Arrow;
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<FileData> fileDatas = new BindingList<FileData>();
            dataGridView1.DataSource = fileDatas;
        }

        private void FilePlace_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                pathJson = dialog.SelectedPath;
            }
        }

        private void Browser2_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                saveLink.Text = dialog.SelectedPath;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(saveLink.Text))
            {
                string jsonOK = JsonConvert.SerializeObject(sortedFileDatas);
                System.IO.File.WriteAllText(saveLink.Text + @"\Result.json", jsonOK);
            }
            
        }
    }
}
