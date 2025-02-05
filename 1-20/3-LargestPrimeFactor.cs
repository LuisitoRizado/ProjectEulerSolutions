using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems._1_20
{
    public class LargestPrimeFactor
    {
        //Descripcion
        //The prime factors of 13195 are 5, 7, 13 and 29
        //To Solve:
        //What is the largest prime factor of the number 600851475143

        public static long LargestPrimeFactorInANumber(long n)
        {
            while (n % 2 == 0)
            {
                n /= 2;
            }

            long largestFactor = 0;
            for (long i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    largestFactor = i;
                    n /= i;
                }
            }

            // Si queda un número mayor que 2, este es primo
            if (n > 2)
                largestFactor = n;

            return largestFactor;
        }
    }
}
