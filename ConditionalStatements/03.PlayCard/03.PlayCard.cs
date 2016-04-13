using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/03.%20Check%20for%20a%20Play%20Card

namespace _03.PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string[] range_specials = { "J", "Q", "K" , "A" } ;

            string user_input = Console.ReadLine();

            switch (user_input)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("yes {0}", user_input); break;
                
                default:
                    Console.WriteLine("no {0}", user_input); break;

            }

        }
    }
}
