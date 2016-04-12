using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/08.%20Catalan%20Numbers/README.md

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            BigInteger factorial2n = 1;
            BigInteger factorialn_plus1 = 1;
            BigInteger factorial_n = 1;

            for (int i = 1; i <= 2*n; i++)
            {
                factorial2n *= i;
            }
            for (int i = 1; i <= n+1; i++)
            {
                factorialn_plus1 *= i;
            }
            for (int i = 1; i <= n ; i++)
            {
                factorial_n *= i;
            }

            BigInteger catalan_formula = factorial2n / (factorialn_plus1 * factorial_n);
            Console.WriteLine(catalan_formula);
        }
    }
}
