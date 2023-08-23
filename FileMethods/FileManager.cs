using System;
using Sys = Cosmos.System;
using System.IO;

namespace CosmosKernel1.FileMethods
{
    public class FileManager
    {
        private FileSysOverview fileSysOverview = new FileSysOverview();
        private AddNewFile AddNewFile = new AddNewFile();
        private RandomFileGen RandomFileGen = new RandomFileGen();
        public string[] FileFeatures = ["FileSysOverview", "CreateNewFile", "WriteFile", "ReadFile", "FileGen"];
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
        public void FileGen()
        {
            Console.WriteLine("Name of the Folder: ");
            Console.Write(@"0:\> ");
            string path=Console.ReadLine();
            Console.WriteLine("MaxDepth:");
            string maxDepth=Console.ReadLine();
            Console.WriteLine("MaxFiles:");
            string maxFiles= Console.ReadLine();
            Console.WriteLine("MaxSubfolders:");
            string maxSubfolders = Console.ReadLine();
            RandomFileGen.CreateRandomFolderStructure(path, Convert.ToInt32(maxDepth), Convert.ToInt32(maxFiles), Convert.ToInt32(maxSubfolders));
        }
    }
}
