using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/07.%20Calculate%203!

namespace _07.Calculate3Fact
{
    class Calculate3Fact
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal k = decimal.Parse(Console.ReadLine());

            BigInteger factorial_n = 1;
            BigInteger factorial_k = 1;
            BigInteger fact_n_k = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial_n *= i;

                if ( (n-k) >= i)
                {
                    fact_n_k *= i;
                }
            }

            for (int i = 1; i <= k; i++)
            {
                factorial_k *= i;
            }

            BigInteger formula = factorial_n / (factorial_k * fact_n_k);
            Console.WriteLine(formula);

        }
    }
}
