namespace DuplicateFileCheck
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.path = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Browser = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddFile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.FilePlace = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SortLabel = new System.Windows.Forms.Label();
            this.Browser2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saveLink = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(102, 31);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(100, 20);
            this.path.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(102, 83);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(208, 29);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(75, 23);
            this.Browser.TabIndex = 2;
            this.Browser.Text = "Browser";
            this.Browser.UseVisualStyleBackColor = true;
            this.Browser.Click += new System.EventHandler(this.Browser_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(320, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(466, 55);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "JsonFileName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(12, 166);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(75, 23);
            this.AddFile.TabIndex = 9;
            this.AddFile.Text = "AddFile";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1248, 420);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Find and Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilePlace
            // 
            this.FilePlace.Location = new System.Drawing.Point(208, 58);
            this.FilePlace.Name = "FilePlace";
            this.FilePlace.Size = new System.Drawing.Size(75, 23);
            this.FilePlace.TabIndex = 12;
            this.FilePlace.Text = "FilePlace";
            this.FilePlace.UseVisualStyleBackColor = true;
            this.FilePlace.Click += new System.EventHandler(this.FilePlace_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(445, 166);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(0, 13);
            this.SortLabel.TabIndex = 13;
            // 
            // Browser2
            // 
            this.Browser2.Location = new System.Drawing.Point(1176, 166);
            this.Browser2.Name = "Browser2";
            this.Browser2.Size = new System.Drawing.Size(75, 23);
            this.Browser2.TabIndex = 14;
            this.Browser2.Text = "Browser";
            this.Browser2.UseVisualStyleBackColor = true;
            this.Browser2.Click += new System.EventHandler(this.Browser2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1037, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Link";
            // 
            // saveLink
            // 
            this.saveLink.Location = new System.Drawing.Point(1070, 166);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(100, 20);
            this.saveLink.TabIndex = 15;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1176, 137);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 627);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveLink);
            this.Controls.Add(this.Browser2);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.FilePlace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Browser;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FilePlace;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saveLink;
        private System.Windows.Forms.Button Browser2;
        private System.Windows.Forms.Button Save;
    }
}

