using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/08.%20Digit%20as%20Word


namespace _08.DigitAsWord
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string num_entered = Console.ReadLine();
            int result; 
  
            if ((int.TryParse(num_entered, out result)) && (int.Parse(num_entered) < 10) && (int.Parse(num_entered) >= 0))
            {
                Console.WriteLine(digits[int.Parse(num_entered)]);
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
