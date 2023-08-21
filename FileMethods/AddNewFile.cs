using System;
using System.IO;

namespace CosmosKernel1.FileMethods
{
    public class AddNewFile
    {
        public bool CreateFile()
        {
            try
            {
                Console.WriteLine("Enter the name of the file: ");
                string filename = Console.ReadLine();
                if (!string.IsNullOrEmpty(filename))
                {
                    var file_stream = File.Create(@"0:\" + filename + ".txt");
                    Console.WriteLine("The file " + filename + ".txt, has been created");
                    return true;
                }
                else throw new Exception("filename is not gud");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
