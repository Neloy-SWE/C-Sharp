using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class ClassCheck
    {

        int id;
        string name;

        // normally jodi ami check method call dei tahole runtime e id 0 and name empty string "" dara initialize hoye jabe

        public void initialize(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void check()
        {
            Console.WriteLine("id: {0}. Name: {1}", id, name);
        }
    }
}
