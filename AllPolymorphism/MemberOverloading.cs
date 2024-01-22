using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// complile time polymorphism

namespace CoreOOP.AllPolymorphism
{
    internal class MemberOverloading
    {

        public MemberOverloading() {
            Console.WriteLine("Default constructor");
        }


        public MemberOverloading(string s)
        {
            Console.WriteLine("Default constructor with parameter: {0}",s);
        }

        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double add(double a, double b)
        {
            return (double)a + b;
        }
    }
}
