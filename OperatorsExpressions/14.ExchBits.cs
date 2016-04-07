using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitExchange
{
    class ExchBits
    {
        static void Main(string[] args)
        {


            /*int mask_3 = 1 << 3;
            int intial_bit_3 = (num & mask_3) >> 3;*/

            uint number = uint.Parse(Console.ReadLine());

            //Console.WriteLine("{0} --> Binary representation of the number.", Convert.ToString(number, 2));

            for (int i = 0; i < 3; i++)
            {
                uint smallRangeBit = ((number >> 3 + i) & 1);
                uint bigRangeBit = ((number >> 24 + i) & 1);

                if (smallRangeBit == 0 && bigRangeBit == 1)
                {
                    number = (uint)(number | (1 << (3 + i)));
                    number = (uint)(number & ~(1 << (24 + i)));
                }
                else if (smallRangeBit == 1 && bigRangeBit == 0)
                {
                    number = (uint)(number | (1 << (24 + i)));
                    number = (uint)(number & ~(1 << (3 + i)));
                }
            }

            //Console.WriteLine("{0} --> Binary representation of the new number.", Convert.ToString(number, 2));
            Console.WriteLine(number);
        }
    }
}
