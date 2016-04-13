using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/homework/09.%20Int%2C%20Double%20and%20String

namespace _10.IntDoubleStr
{
    class IntDoubleStr
    {
        static void Main(string[] args)
        {
            string inn = Console.ReadLine();
            object obj = Console.ReadLine();

            if (inn == "integer" || inn=="int")
            {
                Console.WriteLine(int.Parse(obj.ToString())+1);
            }
            else if (inn == "real" || inn == "double")
            {
                Console.WriteLine("{0:F2}",double.Parse(obj.ToString())+1);
            }
            else if (inn == "text" || inn == "string    ")
            {
                Console.WriteLine(obj.ToString()+"*");
            }

        }
    }
}
