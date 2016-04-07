using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

// https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/homework/12.%20N-th%20bit

namespace NthBit
{
    class BitAtPositionN
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;

            BigInteger result = mask & num;
            BigInteger result_bit = result >> position;
            Console.WriteLine(result_bit);
        }
    }
}
