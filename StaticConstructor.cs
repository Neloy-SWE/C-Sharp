using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class StaticConstructor
    {
        //int a;
        static int a;
        static StaticConstructor()
        {
            //StaticConstructor s = new StaticConstructor();
            //s.a = 10;

            a = 10;
            Console.WriteLine("Initialize value of static member a from static constructor: {0}", a);
        }
    }
}
