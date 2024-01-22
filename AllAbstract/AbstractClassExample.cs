using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllAbstract
{
    internal abstract class AbstractClassExample
    {
        public void checkNonAbstractMethod()
        {
            Console.WriteLine("Non abstract method");
        }

        public abstract void checkAbstractMethod();
    }

    class ChildAbstractClass : AbstractClassExample
    {
        public override void checkAbstractMethod()
        {
            Console.WriteLine("over ridden method");
        }
    }
}
