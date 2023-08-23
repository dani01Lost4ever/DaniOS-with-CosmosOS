using System;
using Sys = Cosmos.System;
using System.IO;


namespace CosmosKernel1.FileMethods
{
    public class FileSysOverview
    {

        //public void FileSysOverviewMethod(Sys.FileSystem.CosmosVFS fs)
        //{
        //    try
        //    {
        //        var available_space = fs.GetAvailableFreeSpace(@"0:\");
        //        Console.WriteLine("Available Free Space: " + available_space * 1e-6 + "MB");
        //        var files_list = Directory.GetFiles(@"0:\");
        //        var directory_list = Directory.GetDirectories(@"0:\");
        //        foreach (var file in files_list)
        //        {
        //            Console.WriteLine("-FILE:  " + file);
        //        }
        //        foreach (var directory in directory_list)
        //        {
        //            Console.WriteLine("-DIR: " + directory);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error has occurred: "+e.Message);
        //    }
        //    Console.WriteLine("File Overview Finished");
        //}
        public void DisplayFileSystemTree(string path, int depth)
        {
            var indent = new string(' ', depth * 4);
            var files = Directory.GetFiles(path);
            var directories = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                Console.WriteLine(indent + "- " + Path.GetFileName(file));
            }

            foreach (var directory in directories)
            {
                Console.WriteLine(indent + "|- " + Path.GetFileName(directory));
                DisplayFileSystemTree(Path.Combine(path, Path.GetFileName(directory)), depth + 1);
            }
        }

        public void FileSysOverviewMethod(Sys.FileSystem.CosmosVFS fs)
        {
            try
            {
                var available_space = fs.GetAvailableFreeSpace(@"0:\");
                Console.WriteLine("Available Free Space: " + available_space * 1e-6 + "MB");

                Console.WriteLine("File Tree:");
                DisplayFileSystemTree(@"0:\", 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has occurred: " + e.Message);
            }
            Console.WriteLine("File Overview Finished");
        }
    }
}
