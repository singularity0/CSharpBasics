using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/10.%20Fibonacci%20Numbers

namespace FiboNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            BigInteger a = 0;
            BigInteger b = 1;
            int counter = 0;

            if (limit == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.Write(a + ", " + b);
                counter += 2;
            }

            while (counter < limit)
            {
                if (limit == 1)
                {
                    break;
                }
                a = a + b;
                Console.Write(", " + a);
                counter++;
                if (counter < limit)
                {
                    b = b + a;
                    Console.Write(", " + b);

                    counter++;
                }

            }
        }
    }
}