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
                features.DisplayFeatures();
                Console.WriteLine("\nSelect the operation:");
                //string input = Console.ReadLine();

                //switch (input)
                //{
                //    case "FileSysOverview":

                //        fileManager.FileSysOverview(fs);
                //        break;

                //    case "CreateNewFile":
                //        fileManager.CreateNewFile();
                //        break;

                //    case "WriteFile":
                //        fileManager.WriteFile();
                //        break;
                //    case "ReadFile":
                //        fileManager.ReadFile();
                //        break;
                //    case "Exit":
                //        bool userChoice = generalManager.Exit();
                //        if (userChoice) Stop();                    
                //        break;

                //    default: Console.WriteLine("wrong input: ", input); break;
                //}

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.D0 || keyInfo.Key == ConsoleKey.NumPad0)
                {
                    Console.Clear();
                    fileManager.FileSysOverview(fs);
                    Console.WriteLine("-------------------------------\n\n");
                    return;
                        
                }
                else if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    fileManager.CreateNewFile();
                    Console.WriteLine("-------------------------------\n\n");
                    return;

                }
                else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    fileManager.WriteFile();
                    Console.WriteLine("-------------------------------\n\n");
                    return;

                }
                else if (keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    fileManager.ReadFile();
                    Console.WriteLine("-------------------------------\n\n");
                    return;

                }
                else if (keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    fileManager.FileGen();
                }
                else if (keyInfo.Key == ConsoleKey.D5 || keyInfo.Key == ConsoleKey.NumPad5)
                {
                    Console.Clear();
                    bool userChoice = generalManager.Exit();
                    if (userChoice) Stop();     
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
