using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class PrintInfo
    {
        static void Main(string[] args)
        {
            string[] fillers = { null, "Address: ", "Tel. ", "Fax: ", "Web site: ", "Manager: ", " (age: ", ", tel. ", ")" };
            string[] input = new string[9];
            string[] output = new string[6];

            for (int i = 0; i <= 8; i++)
            {
                input[i] = Console.ReadLine();
            }
            //Console.WriteLine(input[3] == "");
            for (int i = 0; i < 5; i++)
            {
                output[i] = fillers[i] + input[i];
                if (input[3] == "")
                {
                    output[3] = fillers[3] + "(no fax)";
                }
            }


            output[5] = fillers[5] + input[5] + " " + input[6] + fillers[6] + input[7] + fillers[7] + input[8] + fillers[8];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(output[i]);
            }
            Console.WriteLine(output[5]);
        }
    }
}