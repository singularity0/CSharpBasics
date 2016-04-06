using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGrav
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double moon_weight = weight * 0.17;
      
            Console.WriteLine(String.Format("{0:F3}", moon_weight));
        }
    }
}
