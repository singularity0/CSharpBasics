using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/10.%20Fibonacci%20Numbers

namespace FiboNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int counter = 0;
            int a = 0;
            int b = 1;
            //int temp = new int();
            while (counter < limit)
            {
                if (limit == 1)
                {
                    break;
                }
                Console.Write(a + " ");
                Console.Write(b+ " ");
                //temp = a;
                a = a + b;
                b = b + a;
                counter++;
            }
        }
    }
}
