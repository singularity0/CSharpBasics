using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing
{
    class Printing
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            double P = double.Parse(Console.ReadLine());

            int total_sheets = N * S;
            //Console.WriteLine(total_sheets);
            double realms = total_sheets / 500.00;
            //Console.WriteLine(realms);
            double amount = realms * P;

            Console.WriteLine("{0:F2}", amount);

        }
    }
}
