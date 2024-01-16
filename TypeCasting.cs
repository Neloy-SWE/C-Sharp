using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class TypeCasting
    {
        public void ImplicitCast(int integerValue)
        {
            double d = integerValue; // ekhane integer value autometically cast hoye double hoye jabe
            Console.WriteLine("Converted double value : {0:N2}", d);

            // double theke integer e implicit cast possible na.
        }

        public void ExplicitCast(double doubleValue)
        {
            int i = (int) doubleValue; // double ke integer e newar jonno manual cast kore nite hobe
            Console.WriteLine("Converted int value : {0}",i);
        }

        public void ConvertByMethod(int integerValue, double doubleValue) {
            Console.WriteLine("converting int value to double using methods: {0:N2}. type of the final output: {1}", Convert.ToDouble(integerValue), Convert.ToDouble(integerValue).GetType());
            Console.WriteLine("converting double value to int using methods: {0}. type of the final output: {1}", Convert.ToInt32(doubleValue), Convert.ToInt32(doubleValue).GetType());
        }
    }
}
