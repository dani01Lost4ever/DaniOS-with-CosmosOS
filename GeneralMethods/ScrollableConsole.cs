using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel1.GeneralMethods
{
    public class ScrollableConsole
    {
        static int scrollPosition = 0;
        static int consoleHeight = 25;
        static List<string> consoleBuffer = new List<string>();
        public void addLine(string line)
        {
            consoleBuffer.Add(line);
        }
        public void ScrollableConsoleMethod() {
            //for (int i = 0; i < 500; i++)
            //{
            //    consoleBuffer.Add($"Line {i}");
            //}
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                RenderConsole();

                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow && scrollPosition > 0)
                {
                    scrollPosition--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && scrollPosition < consoleBuffer.Count - consoleHeight)
                {
                    scrollPosition++;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);

        }
        static void RenderConsole()
        {
            for (int i = scrollPosition; i < scrollPosition + consoleHeight && i < consoleBuffer.Count; i++)
            {
                Console.WriteLine(consoleBuffer[i]);
            }
        }
    }
}
