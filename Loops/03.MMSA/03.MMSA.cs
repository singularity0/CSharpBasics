using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/03.%20MMSA%20of%20N%20Numbers

namespace _03.MMSA
{
    class MMSA
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal sum = 0, avg = 0;


            for (int i = 0; i < range; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                min = Math.Min(number, min);
                max = Math.Max(number, max);
                sum += number;
                avg = sum/(i+1);
            }
            Console.Write("{0}\n{1}\n{2}\n{3:F2}", min, max, sum, avg);
        }
    }
}
