using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {
        /*
         * A palindromic number reads the same both ways. 
         * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */ 
        static void Main(string[] args)
        {
            short NumOne = 999;
            short NumTwo = 999;

            int digit1 = 0;
            int digit2 = 0; 
            int digit3 = 0;
            int digit4 = 0;
            int digit5 = 0;
            int digit6 = 0;


            int[] StringArr = new int[NumOne*NumTwo];
            short index = 0;

            int currentNum = 0;

            for (int i = 100; i <= NumOne; i++)
            {
                for (int j = 100; j <= NumTwo; j++)
                {
                    currentNum = i * j;

                    if (Convert.ToString(currentNum).Length == 5)
                    {
                        digit1 = (currentNum - currentNum % 10000) / 10000;
                        digit2 = (currentNum % 10000 - currentNum % 1000) / 1000;
                        digit3 = (currentNum % 1000 - currentNum % 100) / 100;
                        digit4 = (currentNum % 100 - currentNum % 10) / 10;
                        digit5 = currentNum% 10;

                        if (digit5 == digit1)
                        {
                            if (digit4 == digit3)
                            {
                               StringArr[index] = currentNum;
                               index++;
                            }
                        }
                    }
                    else if (Convert.ToString(currentNum).Length == 6)
                    {
                        digit1 = (currentNum - currentNum % 100000) / 100000;
                        digit2 = (currentNum % 100000 - currentNum % 10000) / 10000;
                        digit3 = (currentNum % 10000 - currentNum % 1000)/1000;
                        digit4 = (currentNum % 1000 - currentNum % 100)/100;
                        digit5 = (currentNum % 100 - currentNum % 10)/10;
                        digit6 = currentNum % 10;
                        
                        if (digit6 == digit1)
	                    {
                            if (digit5 == digit2)
                            {
                                if (digit4 == digit3)
                                {
                                    StringArr[index] = currentNum;
                                    index++;
                                }
                            }
	                    }
                    }
                }
            }
            Console.WriteLine(StringArr.Max());
        }
    }
}
