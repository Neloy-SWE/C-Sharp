using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    static class StaticClass
    {
        // all members must be static or will get error
        //int a = 10; 
        static int a = 10;

        public static void check()
        {
            Console.WriteLine("value of a: {0}", a);
        }
    }
}
