using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task2
{
    static void Main(string[] args)
    {
        int num_busses = int.Parse(Console.ReadLine());
        decimal[] busses = new decimal[num_busses];
        for (int i = 0; i < busses.Length; i++)
        {
            busses[i] = decimal.Parse(Console.ReadLine());
        }

        decimal reference = busses[0];
        int counter_groups = 1;

        for (int i = 1; i < busses.Length; i++)
        {
            if (busses[i] <= reference)
            {
                reference = busses[i];
                counter_groups++;
            }
        }
        //Console.WriteLine(busses[2]);
        Console.WriteLine(counter_groups);

    }
}

