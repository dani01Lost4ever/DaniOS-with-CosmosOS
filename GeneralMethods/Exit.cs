using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel1.GeneralMethods
{
    public class Exit
    {
        public bool ExitMethod()
        {
            Console.Clear();
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
                {
                    return true; // User chose Yes
                }
                else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)
                {
                    return false; // User chose No
                }
            }
        }
    }
}
