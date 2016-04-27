using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 2001; // int.Parse(Console.ReadLine());
            string s = "H"; // Console.ReadLine();

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    result += (int)s[i] - 65;
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine(result);
        }
    }
}
