using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class AccessModifierExample
    {
        public void CheckPublic()
        {
            Console.WriteLine("Public");
        }

        protected int a = 10;
        internal int b = 20;
        protected internal int c = 30;

        private int d = 40;
        // private ke nij class er baire ar kothaw access kora jai na. eke access korar jonno public method use kora jete pare.

        public void GetPrivate()
        {
            Console.WriteLine("private member d: " + d);
        }
    }

    class AccessMOdifierCheck: AccessModifierExample
    {
       public void CheckProtected()
        {
            Console.WriteLine("Protected vlaue: "+a);
            // protected member ke access kora jai na sorasori. child class e public method e value niye access kora jai.
        }
    }
}
