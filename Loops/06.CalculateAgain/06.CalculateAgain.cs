using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/07.%20Calculate%203!

namespace _06.CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal k = decimal.Parse(Console.ReadLine());

            BigInteger factorial_smaller = 1;
            BigInteger factorial_bigger = 1;
            decimal bigger = n > k ? n : k;
            decimal smaller = n > k ? k : n;

            for (int i = 1; i <= bigger; i++)
            {
                factorial_bigger *= i;
                if (i <= smaller)
                {
                    factorial_smaller *= i;
                }
            }

            if (n >= k)
            {
                Console.WriteLine(factorial_bigger/ factorial_smaller);
            }
            else
            {
                Console.WriteLine("{0:F3}", factorial_smaller/ factorial_bigger);
            }

        }
    }
}
