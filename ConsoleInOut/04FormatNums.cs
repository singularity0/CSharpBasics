using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormatNums
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string a_transformed = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("|{0, -10 :X}|{1}|{2,10:F2}|{3,-10:0.000}|", a, a_transformed, b, c);

        }
    }
}
