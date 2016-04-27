using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NeuronMapping
{
    static void Main(string[] args)
    {
        while (true)
        {
            long n = long.Parse(Console.ReadLine());
            if (n == -1)
            {
                break;
            }
            //string n_str = Convert.ToString(n, 2).PadLeft(32, '0');

            string n_str = Convert.ToString(n, 2).PadLeft(64, '0');

            Console.WriteLine(n_str);
            int zeroes = 0;
            int ones = 0;

            for (int i = 0; i < n_str.Length; i++)
            {
                if (n_str[i] == '0')
                {
                    zeroes++;
                }
                if (n_str[i] == '1')
                {
                    ones++;
                }
            }
            Console.WriteLine(zeroes);
            Console.WriteLine(ones);

            for (int i = 0; i < n_str.Length; i++)
            {
                if (n_str[i] == '0')
                {
                    continue;
                }
                if (n_str[i] == '1')
                {
                    ones--;
                    int index = Array.IndexOf(n_str.ToCharArray(), n_str[i + 1]); //next element exists
                    if (index > 0 && n_str[index] == '1')  //next el exists and it is 1
                    {
                        
                        continue;
                    }
                    else if (index > 0 && n_str[index] == '0' && ones>0)
                    {

                    }
                }
            }


        }


    }
}

