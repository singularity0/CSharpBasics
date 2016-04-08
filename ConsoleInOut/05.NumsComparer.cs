using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNums
{
    class NumsComparer
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(a>b ? a : b);
            //Console.WriteLine(Math.Max(a,b));
        }
    }
}
