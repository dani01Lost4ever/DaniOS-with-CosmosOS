using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.System.Graphics.Fonts;
using System.IO;
using Cosmos.System.FileSystem.Listing;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        //Canvas canvas;
        Sys.FileSystem.CosmosVFS fs = new Cosmos.System.FileSystem.CosmosVFS();

        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Cosmos booted successfully.");
            FileSysOverview();
        }

        protected override void Run()
        {
            try
            {
                Console.WriteLine("File Overview Finished");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                mDebugger.Send("Exception occurred: " + e.Message);
                mDebugger.Send(e.Message);
                Stop();
            }
        }

        protected void FileSysOverview()
        {
            try
            {
                var available_space = fs.GetAvailableFreeSpace(@"0:\");
                Console.WriteLine("Available Free Space: " + available_space * 1e-6 + "MB");
                var files_list = Directory.GetFiles(@"0:\");
                var directory_list = Directory.GetDirectories(@"0:\");
                foreach (var file in files_list)
                {
                    Console.WriteLine("FILE:  " + file);
                }
                foreach (var directory in directory_list)
                {
                    Console.WriteLine("DIR: " + directory);
                }
            }
            catch (Exception e)
            {
                mDebugger.Send("Exception occurred: " + e.Message);
                mDebugger.Send(e.Message);
                Stop();
            }
        }
    }
}
