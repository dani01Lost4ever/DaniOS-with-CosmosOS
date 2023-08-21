using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.System.Graphics.Fonts;
using System.IO;
using Cosmos.System.FileSystem.Listing;
using CosmosKernel1.FileMethods;
using CosmosKernel1.GeneralMethods;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        public FileManager fileManager = new FileManager();
        public GeneralManager generalManager = new GeneralManager();
        public features features = new features();
        readonly Sys.FileSystem.CosmosVFS fs = new Cosmos.System.FileSystem.CosmosVFS();
        

        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Cosmos booted successfully.");
        }

        protected override void Run()
        {
            try
            {
                Console.WriteLine("Available ops: ");
                foreach (var feature in features.FeaturesList())
                {
                    Console.Write(feature + " ");
                }
                Console.WriteLine("\nSelect the operation:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "FileSysOverview":

                        fileManager.FileSysOverview(fs);
                        break;

                    case "CreateNewFile":
                        fileManager.CreateNewFile();
                        break;

                    case "Exit":
                        bool userChoice = generalManager.Exit();
                        if (userChoice) Stop();                    
                        break;

                    default: Console.WriteLine("wrong input: ", input); break;
                }
                //https://stackoverflow.com/questions/7712137/array-containing-methods
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
