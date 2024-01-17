using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class Functions
    {
        public int ReturnType(int num)
        {
            return num * num;
        }

        public void callByValue(int num)
        {
            num *= num;
            Console.WriteLine("Call by value: {0}", num);
        }

        public void callByReference(ref int num)
        {
            num *= num;
            Console.WriteLine("Call by reference: {0}", num);
        }

        public void callByOut(out int num)
        {
            num = 10;
            Console.WriteLine("assigned value: {0}", num);
            num*= num;
            Console.WriteLine("Change value: {0}", num);
        }
    }
}
