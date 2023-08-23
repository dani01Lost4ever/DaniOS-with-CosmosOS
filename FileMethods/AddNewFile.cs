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
                Console.Write(@"0:\> ");
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
        public bool WriteFile() {
            Console.WriteLine("Enter the Path of the file to write: ");
            Console.Write(@"0:\> ");
            string path = Console.ReadLine();
            Console.WriteLine("Scrivi il contenuto da aggiungere a " + path + " : ");
            string content= Console.ReadLine();
            try
            {
                File.WriteAllText(@"0:\"+ path, content);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public void ReadFile()
        {
            Console.WriteLine("Name of the file to read: ");
            Console.Write(@"0:\> ");
            string path = Console.ReadLine(); 
            try
            {
                Console.WriteLine(File.ReadAllText(@"0:\" + path));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
