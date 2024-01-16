using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class DataTypes
    {
         int intCheck = 10;
         long longCheck = 111111111111;
         float floatCheck = 10.5f;
        double doubleCheck = 33.23452345;
        bool boolCheck = false;
        char charCheck = 'A';
        string stringCheck = "C Sharp program";

        public void printAllValues()
        {
            Console.WriteLine("int value: {0}", intCheck);
            Console.WriteLine("long value: {0}", longCheck);
            Console.WriteLine("float value: {0}", floatCheck);
            Console.WriteLine("double value: {0}", doubleCheck);
            Console.WriteLine("bool value: {0}", boolCheck);
            Console.WriteLine("char value: {0}", charCheck);
            Console.WriteLine("string value: {0}", stringCheck);
        }
    }
}
