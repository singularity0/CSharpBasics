using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/01.%20Sum%20of%203%20numbers

namespace SumOf3Numbers
{
    class Sumof3
    {
        static void Main(string[] args)
        {
            double result = new double();

            for (int i = 0; i < 3; i++)
            {
                result += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
