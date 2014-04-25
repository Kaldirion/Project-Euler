using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            long Num = 600851475143;
            int counter = 0;

            for (long i = 1; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    counter++;
                }
            }

            long[] numArr = new long[counter];
            int index = 0;

            for (long i = 1; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    numArr[index] = i;
                    index++;
                }
            }

            counter = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                for (long j = 2; j < numArr[i]; j++)
                {
                    if (numArr[i] % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine(numArr[i]); 
                }
            }
        }
    }
}
