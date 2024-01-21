using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllInheritance
{
    internal class MultilevelInheritance
    {
        public void checkSupreme()
        {
            Console.WriteLine("Sumpreme class");
        }
    }

    class SubMultilevelParent: MultilevelInheritance
    {
        public void checkSubParent()
        {
            Console.WriteLine("SubParent class");
        }
    }

    class ChildMultilevel: SubMultilevelParent
    {
        public void checkChild()
        {
            Console.WriteLine("Child class");
        }
    }
}
