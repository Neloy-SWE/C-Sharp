using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.AllCollections
{
    internal class ListExample
    {
        public void CheckList()
        {
            List<string> list = new List<string>();
            list.Add("list 1");
            list.Add("list 2");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
