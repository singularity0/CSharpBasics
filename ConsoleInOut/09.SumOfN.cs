using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/09.%20Sum%20of%20n%20Numbers

namespace SumOFN
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyNums = int.Parse(Console.ReadLine());
            float result = new float();
            for (int i = 0; i < howManyNums; i++)
            {
                result += float.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
