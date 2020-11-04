using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 1;
            long num2 = 1;
            long result = 0;
            long summed = 0;

            while (result < 4000000)
            {
                if ((result % 2) == 0)
                {
                    summed += result;
                }

                result = num1 + num2;
                num2 = num1;
                num1 = result;
            }

            Console.WriteLine(summed);

        }//
    }//
}//
