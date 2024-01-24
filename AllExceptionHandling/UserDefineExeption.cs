using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllExceptionHandling
{
    internal class UserDefineExeption : Exception
    {
        public UserDefineExeption(string msg) : base(msg)
        {
        }
    }

    public class CheckUDE
    {
        public void CheckAge(int age)
        {
            if (age < 18)
            {

                throw new UserDefineExeption(msg: "You are not eligible for vote");
            }
        }
    }
}
