using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DrunkenNums
{
    class DrunkenNums
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            int[] number_beers_arr = new int[rounds];

            int vladko_beers = 0;
            int mitko_beers = 0;

            for (int i = 0; i < rounds; i++)
            {
                number_beers_arr[i] = int.Parse(Console.ReadLine());
                if (number_beers_arr[i] < 0)
                {
                    number_beers_arr[i] *= -1;
                }
            }

            //Console.WriteLine(number_beers_arr[0]);

            for (int j = 0; j < number_beers_arr.Length; j++)
            {

                string number_beers_str = number_beers_arr[j].ToString();


                for (int i = 0; i < number_beers_str.Length / 2; i++)
                {

                    vladko_beers += int.Parse(number_beers_str[number_beers_str.Length - 1 - i].ToString());

                    mitko_beers += int.Parse(number_beers_str[i].ToString());
                }

                if (number_beers_str.Length % 2 != 0  )  //num is odd
                {
                    int index = number_beers_str.Length / 2;
                    vladko_beers += int.Parse(number_beers_str[index].ToString());
                    mitko_beers += int.Parse(number_beers_str[index].ToString());

                }

            }

            if (vladko_beers > mitko_beers)
            {
                Console.WriteLine("V {0}", vladko_beers - mitko_beers);
            }
            else if (mitko_beers > vladko_beers)
            {
                Console.WriteLine("M {0}", mitko_beers - vladko_beers);
            }
            else
            {
                Console.WriteLine("No {0}", mitko_beers+vladko_beers);
            }




            



        }
    }
}
