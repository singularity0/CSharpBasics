using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/homework/11.%203rd%20Bit


namespace ThirdBit
{
    class Bit3
    {
        static void Main(string[] args)
        {
            int position = 3;
            int num = int.Parse(Console.ReadLine());
            int mask = 1 << position;

            int result = mask & num;
            int result_bit = result >> position;
            Console.WriteLine(result_bit);
        }
    }
}
