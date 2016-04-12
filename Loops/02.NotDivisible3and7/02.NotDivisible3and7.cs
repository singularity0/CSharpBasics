using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/02.%20Not%20Divisible%20Numbers

namespace _02.NotDivisible3and7
{
    class NotDivisible3and7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 7 == 0 || i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
