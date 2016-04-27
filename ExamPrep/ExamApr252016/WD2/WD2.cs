using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class WD2
{
    static void Main(string[] args)
    {
        int[] fibo = new int[100];
        int first = 1;
        fibo[0] = first;
        int second = 1;
        fibo[1] = second;

        int temp = new int();
        for (int i = 0; i < 60; i++)
        {
            temp = first;
            first = second;
            second = first + temp;
            fibo[i+2] = second;

        }
        for (int i = 0; i < 70; i++)
        {
            Console.WriteLine(fibo[i]);
        }
    }
}

