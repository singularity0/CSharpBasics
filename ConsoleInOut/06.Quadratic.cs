using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/06.%20Quadratic%20Equation

namespace QuadraticEquation
{
    class Quadratic
    {
        static void Main()
        {
            //Console.WriteLine("Enter a,b,c. Press enter after every input.");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1, x2, x;
            double underRoot = Math.Pow(b, 2) - 4 * a * c;
            if (underRoot > 0)
            {
                x1 = (-b + Math.Sqrt(underRoot)) / (2 * a);
                x2 = (-b - Math.Sqrt(underRoot)) / (2 * a);
                Console.WriteLine("{0:F2}", x2);
                Console.WriteLine("{0:F2}", x1);

            }
            else if (underRoot == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("{0:F2}", x);
            }
            else if (underRoot < 0)
            {
                underRoot = Math.Abs(underRoot);
                x1 = (-b + Math.Sqrt(underRoot)) / (2 * a);
                x2 = (-b - Math.Sqrt(underRoot)) / (2 * a);
                Console.WriteLine("no real roots");
            }
        }
    }
}
