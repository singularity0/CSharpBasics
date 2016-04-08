using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("{0:0.00} {1:F2}", perimeter, area);
        }
    }
}
