using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/10.%20Odd%20and%20Even%20Product

namespace _10.OddOrEvenProduct
{
    class OddOrEvenProduct
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            long product_even = 1;
            long product_odd = 1;
            string[] nums;

            nums = Console.ReadLine().Split(' ');
            

            for (int i = 1; i <= nums.Length; i++)
            {
                int num = int.Parse(nums[i-1]);

                if (i % 2 == 0)
                {
                    product_even *= num;
                }
                else
                {
                    product_odd *= num;
                }
            }

            if (product_even == product_odd)
            {
                Console.WriteLine("yes {0}", product_odd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", product_odd, product_even);
            }
        }
    }
}
