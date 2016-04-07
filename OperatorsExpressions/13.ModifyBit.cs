using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/homework/13.%20Modify%20Bit

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            BigInteger bit_value = BigInteger.Parse(Console.ReadLine());

            BigInteger mask;
            BigInteger result;

            if (bit_value == 0)
            {
                mask = ~( 1 << position);
                result = num & mask;
            }
            else
            {
                mask = bit_value << position;
                result = num | mask;
            }
            Console.WriteLine(result);



        }
    }
}
