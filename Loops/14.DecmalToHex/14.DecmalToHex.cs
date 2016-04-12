using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/14.%20Hex%20to%20Decimal

namespace _14.DecmalToHex
{
    class DecmalToHex
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());
            string hexadecimal = string.Empty;
            string[] hexes = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            while (number >= 16)
            {
                hexadecimal = hexes[(number % 16)] + hexadecimal;
                number /= 16;
            }

            hexadecimal = hexes[number] + hexadecimal;
            Console.WriteLine(hexadecimal);

        }
    }
}
