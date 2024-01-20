using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class Params
    {
        public void checkParams(params object[] values)
        {
            // System.Single: Represents a single-precision floating point number
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Value: {0} types: {1}",values[i], values[i].GetType());
            }
        }
    }
}
