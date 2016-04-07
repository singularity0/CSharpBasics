using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class DigitThree
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > 100)
            {
                if (num/100 % 10 == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false " + num/100 % 10);
                }
            }
            else
            {
                Console.WriteLine("false 0");
            }
        }
    }
}
