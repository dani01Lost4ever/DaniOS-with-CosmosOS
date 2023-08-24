using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel1.GeneralMethods
{
    public class GeneralManager
    {
        public string[] GeneralFeatures = ["Exit"];
        Exit exit= new Exit();
        ScrollableConsole scrollableConsole= new ScrollableConsole();
        public bool Exit()
        {
            return exit.ExitMethod();
        }
        public void Scroll()
        {
            scrollableConsole.ScrollableConsoleMethod();
        }
        //public void add(string line)
        //{
        //    scrollableConsole.addLine(line);
        //}
    }
}
