using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    class Coffee_Machine
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine())* 0.05; 
            double n2 = double.Parse(Console.ReadLine()) * 0.10;
            double n3 = double.Parse(Console.ReadLine()) * 0.20;
            double n4 = double.Parse(Console.ReadLine()) * 0.50;
            double n5 = double.Parse(Console.ReadLine()) * 1.00;
            double inserted = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double total = n1 + n2 + n3 + n4 + n5;
            //Console.WriteLine(total);

            if (price<inserted && total<(inserted-price))
            {
                Console.WriteLine("No {0:F2}", (inserted - price) - total);
            }
            else if (inserted >= price)
            {
                Console.WriteLine("Yes {0:F2}", total - (inserted - price));
            }
            else if (price > inserted)
            {
                Console.WriteLine("More {0:F2}", price - inserted);
            }



        }
    }
}
