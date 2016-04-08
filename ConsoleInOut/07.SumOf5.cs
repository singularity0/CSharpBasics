using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/04.%20Console-In-and-Out/homework/07.%20Sum%20of%205%20Numbers
namespace SumOf5
{
    class SumOf5
    {
        static void Main(string[] args)
        {
            int result = new int();
            for (int i = 0; i < 5; i++)
            {
                short s = short.Parse(Console.ReadLine());
                result += s;
            }

            Console.WriteLine(result);
        }
    }
}
