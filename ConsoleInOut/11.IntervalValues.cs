using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/11.%20Interval

namespace Interval
{
    class DivisibleTo5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int counter = new int();

            for (int i = n+1 ; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
