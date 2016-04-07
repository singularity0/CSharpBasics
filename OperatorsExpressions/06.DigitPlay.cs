using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class DigitPlay
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            byte lengthDigit = 4;

            sum(number, lengthDigit);
            reverse_num(number, lengthDigit);
            lastDigitFirst(number, lengthDigit);
            exch_second_third_bit(number, lengthDigit);

        }

        static void exch_second_third_bit(int num, int len)
        {
            string mynumber = num.ToString();
            string first_letter, second_letter, third_letter, fourth_letter;
            first_letter = mynumber.Substring(0, 1);
            second_letter = mynumber.Substring(1,1);
            third_letter = mynumber.Substring(2,1);
            fourth_letter = mynumber.Substring(3,1);

            Console.WriteLine(first_letter+third_letter+second_letter+fourth_letter);
        }

        static void sum(int number, int lengthDigit)
        {
            int result = new int();

            for (int i = 0; i < lengthDigit; i++)
            {
                result += (number % 10);
                number = number / 10;
            }
            Console.WriteLine(result);
        }

        static void lastDigitFirst(int number, int lengthDigit)
        {
            char last_ch = number.ToString()[lengthDigit-1];
            string result = number.ToString().Substring(0, lengthDigit - 1);
            Console.WriteLine(last_ch + result);
        }

        static void reverse_num(int number, int lengthDigit)
        {
            string result = number.ToString();
            Console.WriteLine(result.Reverse().ToArray());
        }
    }
}
