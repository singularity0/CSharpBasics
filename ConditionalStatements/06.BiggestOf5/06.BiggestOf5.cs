using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/06.%20Biggest%20of%205

namespace _06.BiggestOf5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal z = decimal.Parse(Console.ReadLine());
            decimal t = decimal.Parse(Console.ReadLine());
            decimal k = decimal.Parse(Console.ReadLine());

            decimal biggest = new decimal();
            biggest = x;
            if (y>=biggest)
            {
                biggest = y;
            }
            if (z>=biggest)
            {
                biggest = z;
            }
            if (t >= biggest)
            {
                biggest = t;
            }
            if (k >= biggest)
            {
                biggest = k;
            }
            Console.WriteLine(biggest);

        }
    }
}
