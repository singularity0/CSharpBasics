using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class Points
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Eneter x value:");
            double x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Eneter y value:");
            double y = double.Parse(Console.ReadLine());

            double areaXY = (x * x) + (y * y);
            bool IsInside = areaXY <= 2 * 2;
            double formula = Math.Sqrt (areaXY);

            switch (IsInside)
            {
                case true: Console.WriteLine("yes {0:F2}", formula); break;
                case false: Console.WriteLine("no {0:F2}", formula ); break;
                default: Console.WriteLine("Enjoy your day!!"); break;
            }
        }
    }
}
