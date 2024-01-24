using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllExceptionHandling
{
    internal class ExecptionHandlingExample
    {
        public void CheckExeption()
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;

            } catch (Exception e) {
                Console.WriteLine("Exeption: "+e);
            }
            finally
            {
                Console.WriteLine("method close");
            }
        }
    }
}
