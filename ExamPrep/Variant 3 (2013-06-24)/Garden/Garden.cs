using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            decimal total_cost = 0;
            decimal total_area = 0;
            for (int i = 0; i < 11; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                if (i == 0)
                {
                    total_cost += number * 0.5m;
                }                 
                else if (i == 2) 
                {
                    total_cost += number * 0.4m;
                }                 
                else if (i == 4)
                {
                    total_cost += number * 0.25m;
                }                
                else if (i == 6)
                { 
                    total_cost += number * 0.6m;
                }                
                else if (i == 8)  
                {             
                    total_cost += number * 0.3m;
                }           
                else if (i == 10)  
                {             
                    total_cost += number * 0.4m;
                }
                else
                {
                    total_area += number;
                }
            }
            Console.WriteLine("Total costs: {0:F2}", total_cost);
            if (250 - total_area > 0)
            {
                Console.WriteLine("Beans area: {0}", 250 - total_area);
            }
            else if (250 == total_area)
            {
                Console.WriteLine("No area for beans");
            }
            else if (250-total_area < 0)
            {
                Console.WriteLine("Insufficient area");
            }

        }
    }
}
