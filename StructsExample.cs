using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal struct StructsExample
    {
        //public int a = 10; // stuct e direct initialize kora jabe na. constructor use korte hobe
        //public int b = 20;
        public int a;
        static public int b = 10; // static member initialize kora jabe.

        public StructsExample() {
            a = 10;
            //b = 20;
        }
    }
}
