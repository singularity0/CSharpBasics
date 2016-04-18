using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/11.%20Binary%20to%20Decimal

namespace _11.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int number_length = number.ToString().Length;
            ulong numberDec = 0;

            for (int i = 0; i <= number_length; i++)
            {
                if (number % 10 == 1)
                {
                    numberDec += iRaised(i);
                }
                number = number / 10;
                
            }
            Console.WriteLine(numberDec);

        }

        static ulong iRaised(int degree)
        {
            ulong result = 1;
            for (int i = 1; i <= degree; i++)
            {
                result *= 2;
            }
            return result;
        }
    }
}
