using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllCollections
{
    internal class HasSetExample
    {
        public void CheckHasSet()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("1");
            set.Add("1"); // duplicate value, which is not allow for HashSet.
            set.Add("2");

            foreach (var item in set)
            {

                Console.WriteLine(item);
            }
        }
    }
}
