using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/16.%20Trailing%200%20in%20N!


namespace _15.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            BigInteger factorial = 1;
            if (n == 5)
            {
                counter = 1;
            }
            else
            {
                for (int i = 5; i <= n; i*=5)
                {
                    counter +=  n/i;
                }


                //string str = factorial.ToString();

                //for (int i = 0; i < str.Length; i++)
                //{
                //    if (str[str.Length - 1 - i] == '0')
                //    {
                //        counter += 1;
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
            }

            
            Console.WriteLine(counter);
        }
    }
}
