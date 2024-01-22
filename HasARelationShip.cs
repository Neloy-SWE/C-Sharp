using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class HasARelationShip
    {
        public string name;
        public string department;

        public HasARelationShip(string name, string department)
        {
            this.name = name;
            this.department = department;
        }
    }

    class Relations
    {
        int id;
        HasARelationShip har;
        public Relations(int id, HasARelationShip har)
        {
            this.id = id;
            this.har = har;
        }

        public void show()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0}", har.name);
            Console.WriteLine("Department: {0}", har.department);
        }
    }
}
