using System;
using Sys = Cosmos.System;
using System.IO;


namespace CosmosKernel1.FileMethods
{
    public class FileSysOverview
    {

        public void FileSysOverviewMethod(Sys.FileSystem.CosmosVFS fs)
        {
            try
            {
                var available_space = fs.GetAvailableFreeSpace(@"0:\");
                Console.WriteLine("Available Free Space: " + available_space * 1e-6 + "MB");
                var files_list = Directory.GetFiles(@"0:\");
                var directory_list = Directory.GetDirectories(@"0:\");
                foreach (var file in files_list)
                {
                    Console.WriteLine("-FILE:  " + file);
                }
                foreach (var directory in directory_list)
                {
                    Console.WriteLine("-DIR: " + directory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has occurred: "+e.Message);
            }
            Console.WriteLine("File Overview Finished");
        }
    }
}
