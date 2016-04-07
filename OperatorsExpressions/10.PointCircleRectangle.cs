using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool inCircle = Math.Pow(Math.Abs(1-a), 2) + Math.Pow(Math.Abs(1-b), 2) <= Math.Pow(1.5, 2);
            bool inRect = (a >= -1 && a <= 5) && (b >= -1 && b <= 1);
            // R(top=1, left=-1, width=6, height=2).

            if (inCircle == true)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if (inRect == true)
            {
                Console.Write("inside rectangle");
            }
            else
            {
                Console.Write("outside rectangle");
            }

        }
    }
}
