using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class ControlFlowIfElse
    {
        public void checkIfElse(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

        }

        public void checkIf(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("Greater than zero");
            }

            if (num > 10)
            {
                Console.WriteLine("Greater than 10");
            }
        }

        public void checkIfElseIf(int num)
        {
            if (num < 33)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 33 && num < 80)
            {
                Console.WriteLine("Pass");
            }
            else if (num >= 80)
            {
                Console.WriteLine("A plus");
            }
        }

        public void simpleNestedCondition(int num)
        {
            if (num >= 0)
            {
                if (num > 10)
                {
                    Console.WriteLine("Greater than 10");
                }
                else
                {
                    Console.WriteLine("less than 10");
                }
            } else
            {
                Console.WriteLine("less than 0");
            }
        }


    }
}
