using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

            What is the 10 001st prime number?
             */

            int count = 0;
            int mastercount = 0;
            int currentPrime = 0;
            int biggestPrime = 0;

            for (int i = 2; i < 150000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
	                {
                        //Console.WriteLine(i);
                        mastercount++;
                        currentPrime = i;
                        if (currentPrime > biggestPrime)
                        {
                            biggestPrime = currentPrime;
                        }
                        if (mastercount == 10001)
                        {
                            Console.WriteLine(biggestPrime + " " + "<- needed prime number");
                        }
	                }
                count = 0;

            }
        }
    }
}
