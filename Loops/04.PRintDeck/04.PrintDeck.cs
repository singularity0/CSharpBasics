using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/homework/04.%20Print%20a%20Deck

namespace _04.PRintDeck
{
    class PRintDeck
    {
        static void Main(string[] args)
        {
            string[] IDs = {null, null, "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            string[] suites = { "spades", "clubs", "hearts", "diamonds" };

            string entered = Console.ReadLine();
            switch (entered)
            {
                case "J": entered = 11.ToString(); break;
                case "D": entered = 12.ToString(); break;
                case "K": entered = 13.ToString(); break;
                case "A": entered = 14.ToString(); break;
            }

            for (int i = 2; i <= int.Parse(entered); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(IDs[i]+ " of " + suites[j]);
                    if (i == int.Parse(entered) && j == 3)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            } 

        }
    }
}
