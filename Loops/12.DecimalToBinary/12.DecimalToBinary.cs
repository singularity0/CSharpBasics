using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/12.%20Decimal%20to%20Binary

namespace _12.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = "";

            while (number >= 1)
            {
                result = number % 2 + result;
                number /= 2;
            }
            Console.WriteLine(result);
        }
    }
}
