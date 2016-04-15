using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawCube
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.Write(new string(' ', n-1));

            Console.Write(new string(':', n));
            
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(new string(' ', n - 2 - i));
                Console.Write(":");
                Console.Write(new string('/', n-2));
                Console.Write(":");
                Console.Write(new string('X', i));
                Console.Write(":");
                Console.WriteLine();
            }
            Console.Write(new string(':', n));
            Console.Write(new string('X', n-2));
            Console.Write(":");
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(":");
                Console.Write(new string(' ', n - 2));
                Console.Write(":");
                Console.Write(new string('X', n - 3 - i));
                Console.Write(":");
                Console.WriteLine();
            }
            Console.Write(new string(':', n));
        }
    }
}
