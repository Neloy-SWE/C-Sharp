using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllPolymorphism
{
    internal class BaseExample
    {
        public int a;
        public BaseExample(int a)
        {
            this.a = a;
            Console.WriteLine("Base class");
        }
        //public BaseExample() {

        //    Console.WriteLine("Base class");
        //}

        public void baseMethod()
        {
            Console.WriteLine("Base method");
        }
    }

    class BaseChild: BaseExample
    {
        public int b;
        public BaseChild(int a, int b) : base(a)
        {
            this.b = b;
            Console.WriteLine("Child class");
        }


        //public BaseChild()
        //{
        //    Console.WriteLine("Child class");
        //}

        public void childCheck()
        {
            base.baseMethod();
            Console.WriteLine("child method");
        }
    }
}
