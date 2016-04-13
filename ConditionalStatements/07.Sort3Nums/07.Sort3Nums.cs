using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/07.%20Sort%203%20Numbers

namespace _07.Sort3Nums
{
    class Sort3Nums
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal z = decimal.Parse(Console.ReadLine());
            //decimal bigger = new decimal();

            if (x>=y && x>=z)
            {

                if (y>=z)
                {
                    Console.WriteLine("{0} {1} {2}", x, y, z);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", x, z, y);
                }
            }
            else if (y >= x && y >= z)
            {

                if (x >= z)
                {
                    Console.WriteLine("{0} {1} {2}", y, x, z);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", y, z, x);
                }
            } else if (z >= x && z >= x)
            {
                if (x >= y)
                {
                    Console.WriteLine("{0} {1} {2}", z, x, y);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", z, y, x);
                }
            }

        }
    }
}
