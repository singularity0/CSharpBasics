using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/08.%20Numbers%20from%201%20to%20n

namespace Numbers1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
