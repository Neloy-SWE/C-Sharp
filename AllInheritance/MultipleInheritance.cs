using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllInheritance
{
    interface MultipleInheritance
    {
        //public void common()
        //{
        //    Console.WriteLine("Common1 method");
        //}

        void common()
        {
            Console.WriteLine("Common1 method");
        }

        void method1()
        {
            Console.WriteLine("Method1");
        }
    }

    interface MultipleInheritance2
    {
        void common()
        {
            Console.WriteLine("Common2 method");
        }

        void method2()
        {
            Console.WriteLine("Method2 method");
        }
    }


    class childMultipleInheritance : MultipleInheritance, MultipleInheritance2
    {
        public void common()
        {
            Console.WriteLine("from child class");
        }

        public void method1()
        {
            Console.WriteLine("Method1 method");
        }
    }
}
