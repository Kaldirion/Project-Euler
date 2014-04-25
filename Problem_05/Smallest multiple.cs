using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05
{
    class Program
    {
        /* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
           What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?*/

        static void Main(string[] args)
        {

            int divided = 0;

            for (int i = 50000000; i < 700000000; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        divided++;
                    }
                }

                if (divided == 20)
                {
                    Console.WriteLine(i);
                }

                divided = 0;
            }
        }
    }
}
