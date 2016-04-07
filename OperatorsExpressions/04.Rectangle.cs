using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            double width, height = new double();
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * width + 2 * height; 
            Console.WriteLine(String.Format("{0:F2} {1:F2}", area, perimeter ));
        }
    }
}
