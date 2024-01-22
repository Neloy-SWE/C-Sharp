using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllPolymorphism
{
    internal class Overriding
    {
        public virtual void check()
        {
            Console.WriteLine("Parent class");
        }
    }

    class Child : Overriding
    {

        public override void check()
        {
            Console.WriteLine("child class");
        }
    }
}
