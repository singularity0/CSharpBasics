using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TextToNums
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            s = s.ToLower();
            decimal result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == '@')
                {
                    break;
                }
                if (Char.IsLetter(c))
                {
                    result += (int)c - 'a';
                }
                else if (Char.IsDigit(c))
                {
                    result *= (int)c - (int)'0';
                }
                else
                {
                    result = result % num;
                }

            }
            Console.WriteLine(result);
        }
    }
}
