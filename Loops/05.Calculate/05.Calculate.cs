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
            decimal n = decimal.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / xRaised(x, i);
            }
            Console.WriteLine("{0:F5}", sum);
        }

        static double xRaised(double xx, int degree)
        {
            double result = 1;
            for (int i = 1; i <= degree; i++)
            {
                result *= xx;
            }
            return result;
        }
    }
}
