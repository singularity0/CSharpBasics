using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/11.%20Binary%20to%20Decimal

namespace _11.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal number_length = number.ToString().Length;
            decimal numberDec = 0;

            for (int i = 0; i <= number_length; i++)
            {
                if (number % 10 == 1)
                {
                    numberDec += Convert.ToDecimal(Math.Pow(2, i));
                }
                number = Math.Truncate(number / 10 );
            }
            Console.WriteLine(numberDec);


        }
    }
}
