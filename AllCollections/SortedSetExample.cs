using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllCollections
{
    internal class SortedSetExample
    {
        public void CheckSortedSet()
        {
            SortedSet<string> list = new SortedSet<string>();
            list.Add("1");
            list.Add("1"); // duplicate value, which is not allow for HashSet.
            list.Add("2");
            list.Add("5");
            list.Add("4");
            list.Add("3");

            // sorted set will sort all values

            foreach (var item in list)
            {

                Console.WriteLine(item);
            }
        }
    }
}
