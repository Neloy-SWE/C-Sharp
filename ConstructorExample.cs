using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class ConstructorExample
    {
        int a;
       public ConstructorExample(int a) // access modifier public na korle object initialize er somoy error dibe
        {
            Console.WriteLine("calling parameterized constructor");
            this.a = a;
        }

        public ConstructorExample()
        {
            Console.WriteLine("calling default constructor and example for overloading.");
        }

        public void check()
        {
            Console.WriteLine("value of a: {0}", a);
        }
    }
}
