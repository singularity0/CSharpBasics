using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task4
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char ch = Convert.ToChar(Console.ReadLine());
        int odd_counter = 1;
        for (int i = 5; i < n; i += 2)
        {
            odd_counter += 1;
        }
        int some_value = 0;

        //fibo logic
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
            fibo[i + 2] = second;
        }

        //odd_counter = fibo[odd_counter];
        int fibo_counter = fibo[odd_counter];

        //wings + eyes
        for (int i = 0; i < fibo_counter + 1; i++)
        {
            if (i == fibo_counter)
            {
                Console.Write(new string(' ', i));
                Console.Write(new string(ch, n - i));
                Console.Write(new string(' ', (n - 3) / 2)); //3 = eyes + space between
                Console.Write(new string(ch, 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string(ch, 1));
                Console.Write(new string(' ', (n - 3) / 2)); //3 = eyes + space between
                Console.Write(new string(ch, n - i));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string(' ', i));
                Console.Write(new string(ch, n - i));
                Console.Write(new string(' ', n));
                Console.Write(new string(ch, n - i));
                some_value = n - i;
                Console.WriteLine();
            }

        }
        //body
        for (int i = 0; i < fibo_counter; i++)
        {
            Console.Write(new string(' ', fibo_counter + 1));
            //Console.Write(new string(ch, n*2+1));
            Console.Write(new string(ch, (n * 3) - (fibo_counter + 1) * 2));

            Console.Write(new string(' ', (n * 3) - (odd_counter + 1) - (n * 2 + 1)));
            Console.WriteLine();
        }

        //legs
        for (int i = 0, down_count = n - 2; i < fibo_counter + 1; i++, down_count -= 2)
        {
            if (down_count < 0)
            {
                break;
            }
            Console.Write(new string(' ', n + 1 + i));
            Console.Write(new string(ch, down_count));
            Console.Write(new string(' ', n + 1 + i));
            Console.WriteLine();
        }
        //Console.WriteLine(odd_counter);

    }
}