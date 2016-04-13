using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/01.%20Exchange%20If%20Greater

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal temp = new decimal();

            if (x > y)
            {
                temp = x;
                x = y;
                y = temp; 
            }

            Console.Write(x + " ");
            Console.Write(y);


        }
    }
}
