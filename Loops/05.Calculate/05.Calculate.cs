using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/05.%20Calculate!

namespace _05.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());

            decimal sum = 1;
            decimal factorial = 1;

            for (int i = 1 ; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / Convert.ToDecimal(Math.Pow((double)x, i));
            }
            Console.WriteLine("{0:F5}", sum);

        }
    }
}
