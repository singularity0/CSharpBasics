using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecretsOfNumbers
{
    class SEcretOfNums
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            BigInteger R = 0;
            BigInteger Special_sum = 0;
            string str_out = "";
            if (BigInteger.Parse(n) < 0)
            {
                n=n.Substring(1);
            }
            for (int i = 1; i <= n.Length; i++)
            {
                if (i % 2 != 0) // even
                {
                    Special_sum += (n[n.Length - i]-'0') * (i * i);
                }
                else //odd
                {
                    Special_sum += (n[n.Length - i] - '0') * (n[n.Length - i]-'0') * i;
                }
            }
            Console.WriteLine(Special_sum);
            if (Special_sum % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", n);
            }
            else
            {
                R = (Special_sum % 26);
                for (int i = 0; i < Special_sum % 10; i++)
                {
                    str_out += ((char) ('A' + R + i)) ;
                    if ((char)('A' + R + i)== 'Z')
                    {
                        R -= 26;
                    }
                }
                Console.WriteLine(str_out);

            }
        }
    }
}
