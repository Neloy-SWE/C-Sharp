using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllInheritance
{
    internal class HierarchicalInheritance
    {
        public void checkHI()
        {
            Console.WriteLine("Supreme class");
        }
    }

    class Level1HIClass : HierarchicalInheritance
    {
        public void checkHILevel1()
        {
            Console.WriteLine("Level1 class");
        }

    }

    class Child1: Level1HIClass
    {
        public void checkChild1()
        {
            Console.WriteLine("Child1 class");
        }
    }

    class Child2 : Level1HIClass
    {
        public void checkChild2()
        {
            Console.WriteLine("Child2 class");
        }
    }
}
