using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int input_number = int.Parse(Console.ReadLine());
            if (input_number % 2 == 0)    // ((input_number & 1) == 0)
            {
                Console.WriteLine("even " + input_number);
            }
            else
            {
                Console.WriteLine("odd " + input_number);

            }


        }
    }
}



