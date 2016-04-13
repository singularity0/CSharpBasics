using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/04.%20Multiplication%20Sign

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal z = decimal.Parse(Console.ReadLine());

            if (x == 0 || y == 0 || z == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string s = (Math.Sign(x * y * z) == -1) ? ("-") : ("+") ;
                Console.WriteLine(s);
            }

        }
    }
}
