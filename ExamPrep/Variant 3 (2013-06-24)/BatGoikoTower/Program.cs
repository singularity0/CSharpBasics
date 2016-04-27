using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int step = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n-1-i));
                Console.Write(new string('/', 1));
                if (counter == i)
                {
                    Console.Write(new string('-', n * 2 - (n - 1 - i) * 2 - 2));
                    counter += 2 + step;
                    step++;
                }
                else
                {
                    Console.Write(new string('.', n * 2 - (n - 1 - i) * 2 - 2));
                }
                Console.Write(new string('\\', 1));
                Console.Write(new string('.', n - 1 - i));
                Console.WriteLine();
            }


        }
    }
}
