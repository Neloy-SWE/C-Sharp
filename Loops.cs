using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP
{
    internal class Loops
    {
        public void checkForLoop(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void checkWhileLoop(int num)
        {
            int i = 1;
            while (i <= num)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void checkDoWhileLoop(int num)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= num);
        }

        public void simpleNestedLoop()
        {
            for (int i =1; i <= 2; i++)
            {
                for (int j =1; j <= 2; j++)
                {
                    Console.WriteLine("{0}, {1}",i, j);
                }
            }
        }

        public void checkBreakContinue(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                    // skiping steps
                }
                if (i > 5)
                {
                    Console.WriteLine("Loop break");
                    break;
                    // breaking loop
                }
                Console.WriteLine(i);
            }
        }
    }
}
