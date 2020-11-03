using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int m = 0; m < 1000; m++)
            {
                if ((m % 3 == 0) || (m % 5 == 0))
                {
                    sum = sum + m;
                }
            }

            Console.WriteLine(sum);


        }//
    }//
}//
