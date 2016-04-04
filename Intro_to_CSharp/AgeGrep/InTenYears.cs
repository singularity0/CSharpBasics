using System;
using System.Globalization;


namespace AgeGrep
{
    class InTenYears
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime input = DateTime.ParseExact(Console.ReadLine(),"MM'.'dd'.'yyyy", provider);
            int year = input.Year;
            int current_age;
            int in_ten_years;
            if (DateTime.Now.Month > input.Month)
            {
                current_age = DateTime.Now.Year - year;
                in_ten_years = current_age + 10;
            }
            else
            {
                current_age = DateTime.Now.Year - year -1 ;
                in_ten_years = current_age + 10;
            }


            Console.WriteLine(current_age);
            Console.WriteLine(in_ten_years);
        }
    }
}
