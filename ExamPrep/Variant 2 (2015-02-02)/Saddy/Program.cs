using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Saddy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger product = 1;
            int transformations = 0;
            BigInteger sum_of_digits = 0;

            while (number.ToString().Length > 1 && transformations < 10)
            {
                product = 1; 
                while (number.ToString().Length > 0)
                {   

                    number = number / 10;
                    if (number==0)
                    {
                        break;
                    }
                    for (int i = 0; i < number.ToString().Length; i += 2)
                    {
                        sum_of_digits += (long)number.ToString()[i] - '0';
                        //Console.WriteLine(sum_of_digits);
                    }
                    if (sum_of_digits > 0)
                    {
                        product *= sum_of_digits;
                    }
                    sum_of_digits = 0;

                }
                transformations++;
                number = product;
            }
            if (transformations < 10)
            {
                Console.WriteLine(transformations);

            }
            Console.WriteLine(number);


        }
    }
}
