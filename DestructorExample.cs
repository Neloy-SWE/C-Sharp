using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class DestructorExample
    {
        public DestructorExample()
        {
            Console.WriteLine("Constructor calling");
        }

        ~DestructorExample()
        {
            Console.WriteLine("Program execution finish");
        }

        public void checkObject()
        {
            Console.WriteLine("using object of the class");
        }
    }
}
