using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllAbstract
{
    internal interface InterfaceExample
    {

        int check();

        public void TypeCheck()
        {
            Console.WriteLine("Interface");
        }
    }

    class ChildInterfaceClass : InterfaceExample
    {
        public int check()
        {
            return 54321;   
        }
    }
}
