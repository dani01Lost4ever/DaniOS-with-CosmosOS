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
            try
            {
                if (!Directory.Exists(baseFolderPath))
                {
                    Directory.CreateDirectory(baseFolderPath);
                }

                CreateRandomFiles(baseFolderPath, maxFilesPerFolder);

                if (maxDepth > 0)
                {
                    int numSubfolders = new Random().Next(1, maxSubfolders + 1);
                    for (int i = 0; i < numSubfolders; i++)
                    {
                        string subfolderName = Path.GetRandomFileName();
                        string subfolderPath = Path.Combine(baseFolderPath, subfolderName);
                        Directory.CreateDirectory(subfolderPath);

                        CreateRandomFiles(subfolderPath, maxFilesPerFolder);

                        CreateRandomFolderStructure(subfolderPath, maxDepth - 1, maxFilesPerFolder, maxSubfolders);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void CreateRandomFiles(string folderPath, int maxFiles)
        {
            int numFiles = new Random().Next(1, maxFiles + 1);
            for (int i = 0; i < numFiles; i++)
            {
                string fileName = Path.GetRandomFileName() + ".txt";
                File.Create(Path.Combine(folderPath, fileName)).Close();
            }
        }
    }
}
