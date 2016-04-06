using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToChar(42));
            string first = "hello";
            string second = "world";
            object concat = first + " " + second;
            string conv = Convert.ToString(concat);
            Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
            Console.WriteLine("The \"use\" of quotations causes difficulties.");
            Console.WriteLine("ссдсде");

            int len = 7;
            for (int i = 1; i <= len; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("o ".PadLeft( len/(len/2)+len-i, ' '));
                    Console.WriteLine("Nice text here");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            int a = 5;
            int b = 10;
            int exch = b;
            b = a;
            a = exch;
            Console.WriteLine("{0} {1}", a, b);

            int? myNull = null;
            double? d = 2.3d; 
            Console.WriteLine(myNull * d * 2);

            double x = 5.0000001; //double.Parse(Console.ReadLine());
            double y = 5.0000002; //double.Parse(Console.ReadLine());
            double eps = 0.000001;
            Console.WriteLine( ((x > y? x : y) - (x<y? x :y)  <= eps).ToString().ToLower());

            for (int i = 33; i <= 126; i++)
            {
                Console.Write(Convert.ToChar(i));
            }

            Console.WriteLine();
            Console.WriteLine("text here " + new string('@', 10)+ " more text");



        }
    }
}
