using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task1
{
    static void Main(string[] args)
    {
        decimal birds = decimal.Parse(Console.ReadLine());
        decimal feathers = decimal.Parse(Console.ReadLine());
        decimal average = new decimal();
        string result = "";
        if (birds == 0 || feathers == 0 || feathers / birds < 0.0m)
        {
            average = 0.0m;
        }
        else
        {
            average = (decimal)(feathers / birds);
        }

        if (birds % 2 == 0)
        {
            result = (average * 123123123123.0m).ToString();
        }
        else if (birds % 2 != 0)
        {
            result = (average / 317.0m).ToString();
        }
        //double x = double.Parse(result);
        //Console.WriteLine(x);
        Console.WriteLine("{0:F4}", double.Parse(result));
    }
}

