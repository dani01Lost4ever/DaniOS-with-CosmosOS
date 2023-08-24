using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel1.FileMethods
{
    public class RandomFileGen
    {
        public void CreateRandomFolderStructure(string baseFolderPath, int maxDepth, int maxFilesPerFolder, int maxSubfolders)
        {
            Console.Clear();
            Console.WriteLine("Summary of the data entered:" + " Path: "+baseFolderPath+" maxDepth: "+ maxDepth+ " maxFilesPerFolder: "+ maxFilesPerFolder+ " maxSubfolders: "+ maxSubfolders);
            try
            {
                if (!Directory.Exists(baseFolderPath))
                {
                    Console.WriteLine("__Creating a new folder....");
                    Directory.CreateDirectory(baseFolderPath+"\\");
                    Console.WriteLine("__Folder Created!");
                }

                CreateRandomFiles(baseFolderPath, maxFilesPerFolder);

                if (maxDepth > 0)
                {
                    int numSubfolders = new Random().Next(1, maxSubfolders + 1);
                    Console.WriteLine("__Number of subfolders: " + numSubfolders);
                    for (int i = 0; i < numSubfolders; i++)
                    {
                        string subfolderName = Path.GetRandomFileName();
                        Console.WriteLine($"__Subfolder name: {subfolderName}");
                        string subfolderPath = Path.Combine(baseFolderPath, subfolderName);
                        Console.WriteLine($"__Subfolder path: {subfolderPath}");
                        Directory.CreateDirectory(subfolderPath);
                        Console.WriteLine("__Subfolder created!");
                        CreateRandomFiles(subfolderPath, maxFilesPerFolder);

                        CreateRandomFolderStructure(subfolderPath, maxDepth - 1, maxFilesPerFolder, maxSubfolders);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("ERROR: "+ex.Message);
            }
            
        }

        public void CreateRandomFiles(string folderPath, int maxFiles)
        {
            
            int numFiles = new Random().Next(1, maxFiles + 1);
            Console.WriteLine($"__Creating {numFiles} random files...");
            for (int i = 0; i < numFiles; i++)
            {
                string fileName = Path.GetRandomFileName() + ".txt";
                File.Create(Path.Combine(folderPath, fileName)).Close();
                Console.WriteLine($"{fileName} Created!");
            }
            Console.WriteLine("__Files Created!");
        }
    }
}
