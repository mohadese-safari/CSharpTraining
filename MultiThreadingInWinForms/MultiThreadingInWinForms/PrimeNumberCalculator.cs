using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingInWinForms
{
    class PrimeNumberCalculator
    {

        public long NthPrimeNumber(int n)
        {
            throw new Exception();
            int i,count = 0;
            for ( i = 2; count < n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            return i-1;
        }

        public bool IsPrime(long number)
        {
            long n = (long)Math.Sqrt(number);
            for (int i = 2; i <= n; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
