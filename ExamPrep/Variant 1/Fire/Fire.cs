﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', (n-2)/2-i));
                Console.Write(new string('#',1));
                Console.Write(new string('.', i*2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', (n - 2) / 2 - i));
                Console.WriteLine();
            }
            for (int i = 0; i < n/4; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', n-2-i*2));
                Console.Write(new string('#', 1));
                Console.WriteLine(new string('.', i));
            }

            Console.WriteLine(new string('-',n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('\\', n / 2 - i));
                Console.Write(new string('/', n / 2 - i));
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

        }
    }
}
