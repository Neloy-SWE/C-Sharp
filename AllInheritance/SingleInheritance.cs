using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllInheritance
{
    internal class SingleInheritance
    {
        public void check()
        {
            Console.WriteLine("Parent class");
        }
    }

    class ChildSingleInheritanceClass : SingleInheritance
    {
        public void checkChild()
        {
            Console.WriteLine("Child class");
        }
    }
}
