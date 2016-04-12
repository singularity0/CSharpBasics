using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/14.%20Hex%20to%20Decimal

namespace _13.HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            string[] hexes = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            decimal result = new decimal();
            for (int i = 0; i < str.Length; i++)
            {
                string character = str[str.Length - 1 - i].ToString();
                int index = Array.IndexOf(hexes, character);
                result += index * Convert.ToDecimal(Math.Pow(16, i));

            }
            Console.WriteLine(result);
        } 
    }
}
