﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimCh
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool button = true;
            if (num != 1 && num > 0)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("false");
                        button = false;
                        break;
                    }
                }
            }
            else if (num <= 0)
            {
                Console.WriteLine("false");
                button = false;
            }

            if (button)
            {
                Console.WriteLine("true");
            }
            
        }
    }
}
