using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class StaticExample
    {
        static public int a = 10;
        static public int count = 0;

        static public void checkStaticMethod()
        {
            Console.WriteLine("This is a static method. calling useing class");
        }

        public StaticExample()
        {
            count++;
        }
    }
}
