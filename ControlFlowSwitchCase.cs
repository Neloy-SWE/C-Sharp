using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class ControlFlowSwitchCase
    {
        public void checkSwitchCase(double num)
        {
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;

                case 1:
                    Console.WriteLine("Odd");
                    break;

                default:
                    Console.WriteLine("Default value");
                    break;

            }
        }
    }
}
