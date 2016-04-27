using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task5
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int combs = int.Parse(Console.ReadLine());
        List < int > li = new List<int>();
        int second_max = 0;
        for (int i = 0; i < combs; i++)
        {
            int comb_iter = int.Parse(Console.ReadLine());
            li.Add(comb_iter);
            li.Sort();
            
          
        }
        Console.WriteLine(li[li.Count-1]);
    }
}

