using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; 

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int cnt = 2;
            BigInteger limit = BigInteger.Pow(10,9);
            BigInteger[] fib = new BigInteger[3];

            fib[0] = 1;
            fib[2] = 1;

            while (fib[i] <= limit)
            {
                i = (i + 1) % 3;
                cnt++;
                fib[i] = fib[(i + 1) % 3] + fib[(i + 2) % 3];
            }
            BigInteger fin = fib[i];
            Console.WriteLine(fin);


            //Okay, no lie, I do not understand this one. I know I can find/ work out the right answer with more time,
            //and I know I am on the right track, but for now, I am throwing in the towel. 
   
        }
    }
}
