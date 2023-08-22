using System;
using Sys = Cosmos.System;
using System.IO;

namespace CosmosKernel1.FileMethods
{
    public class FileManager
    {
        private FileSysOverview fileSysOverview = new FileSysOverview();
        private AddNewFile AddNewFile = new AddNewFile();
        public string[] FileFeatures = ["FileSysOverview", "CreateNewFile", "WriteFile", "ReadFile"];
        public void FileSysOverview(Sys.FileSystem.CosmosVFS fs)
        {
            fileSysOverview.FileSysOverviewMethod(fs);
        }
        public bool CreateNewFile()
        {
            return AddNewFile.CreateFile();
        }
        public bool WriteFile() 
        { 
            return AddNewFile.WriteFile(); 
        }
        public void ReadFile()
        {
            AddNewFile.ReadFile();
        }
    }
}
