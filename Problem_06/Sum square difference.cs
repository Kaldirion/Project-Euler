using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06
{
    class Program
    {
        /*
        The sum of the squares of the first ten natural numbers is,
        1^2 + 2^2 + ... + 10^2 = 385

        The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)^2 = 55^2 = 3025

        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        */

        static void Main(string[] args)
        {
            long sumOne = 0;

            long sumTwo = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOne = sumOne + i * i;
            }

            for (int i = 0; i <= 100; i++)
            {
                sumTwo = sumTwo + i;
            }

            sumTwo = sumTwo * sumTwo;

            Console.WriteLine(sumTwo-sumOne);

        }
    }
}
