using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/01.%20Numbers%20from%201%20to%20N

namespace Numbers1toN
{
    class Nums1N
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
