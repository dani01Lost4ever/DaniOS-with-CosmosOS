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
        public bool Exit()
        {
            return exit.ExitMethod();
        }
    }
}
