using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task3
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] pages = new string[n];
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            //pages[i-1] = i.ToString();
            counter += (i).ToString().Length;
        }
        //foreach (var item in pages)
        //{
        //    counter += item.Length;
        //}
        Console.WriteLine(counter);
    }
}

