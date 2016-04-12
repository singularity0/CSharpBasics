using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/16.%20Trailing%200%20in%20N!


namespace _15.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            //int trailing = new int();
            int counter = 0;

            while (true)
            {
                if (n % 10 == 0)
                {
                    counter += 1;
                    n = n / 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
