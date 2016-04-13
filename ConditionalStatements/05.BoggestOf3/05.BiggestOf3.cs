using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/05.%20Biggest%20of%203

namespace _05.BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal z = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(x, y), z));

            //if (x > y)
            //{
            //    Console.WriteLine(Math.Max(x, z));
            //}
            //else
            //{
            //    Console.WriteLine(Math.Max(y, z));
            //}
        }
    }
}
