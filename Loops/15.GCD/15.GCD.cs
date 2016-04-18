using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/15.%20GCD

namespace _15.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);

            //int bigger = Math.Max(a, b);
            //int smaller = a > b ? b : a;
            int remainder = new int();

            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            do
            {
                
                remainder = a % b;
                a = b;
                b = remainder;
            } while (remainder != 0);
            Console.WriteLine(Math.Abs(a));

        }
    }
}
