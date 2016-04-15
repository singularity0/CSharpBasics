using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SaddyKopper
{
    class SaddyKopper
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int product = 1;

            string num_to_string = Convert.ToString(num);

            while (num_to_string.Length > 1)
            {
                num_to_string = removeLastDigit(num_to_string);
                int latest_sum_even = Sums_at_even(num_to_string);
                product *= latest_sum_even;
            }
            //Console.WriteLine(product);

            int counter_transofrmations = 1;

            num = product;
            num_to_string = Convert.ToString(num);
            product = 1;

            while (num_to_string.Length > 1)
            {
                counter_transofrmations++;
                num_to_string = removeLastDigit(num_to_string);
                int latest_sum_even = Sums_at_even(num_to_string);
                product *= latest_sum_even;
                
                if (counter_transofrmations == 10)
                {
                    break;
                }
            }
            if (counter_transofrmations == 10)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine(counter_transofrmations);
                Console.WriteLine(product);
            }



        }
        static string removeLastDigit(string num_to_string)
        {
            return Convert.ToString(int.Parse(num_to_string) / 10);
        }

        static int Sums_at_even(string num_to_string)
        {
            int sum_at_even = new int();

            for (int i = 0; i < num_to_string.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum_at_even += int.Parse(num_to_string[i].ToString());
                }
            }
            return sum_at_even;
        }

        
    }
}
