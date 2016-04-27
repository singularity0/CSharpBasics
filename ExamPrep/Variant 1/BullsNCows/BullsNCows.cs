using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsNCows
{
    class BullsNCows
    {
        static void Main(string[] args)
        {
            string guessnum = Console.ReadLine();
            int bulls_requested = int.Parse(Console.ReadLine());
            int cows_requested = int.Parse(Console.ReadLine());
            bool solution_found = new bool();


            for (int current = 1111; current < 9999; current++)
            {
                

                char[] guess = guessnum.ToCharArray();
                char[] current_num = current.ToString().ToCharArray();
                int bulls_found = new int();
                int cows_found = new int();

                if (current_num.Contains('0'))
                {
                    continue;
                }

                //check for bulls
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == current_num[i])
                    {
                        bulls_found++;
                        guess[i] = '@';
                        current_num[i] = '#';
                    }
                }

                //check for cows
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < current_num.Length; j++)
                    {
                        if (guess[i] == current_num[j])
                        {
                            cows_found++;
                            //guess[j] = '@';
                            //int index = Array.IndexOf(current_num, guess[j]);
                            //if (index >= 0)
                            //{
                            //    current_num[index] = '#';
                            //}
                            guess[i] = '@';
                            current_num[j] = '#';
                        }
                    }
                    
                }
                if (bulls_found== bulls_requested && cows_found==cows_requested)
                {
                    Console.Write("{0} ",current);
                    solution_found = true;
                }

            }
            if (!solution_found)
            {          
                Console.WriteLine("No");
            }
        }
    }
}
