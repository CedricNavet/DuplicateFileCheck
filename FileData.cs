using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFileCheck
{
    public class FileData
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public DateTime DateLastestModif { get; set; }
    }
}
