using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to rearrange to Greatest");

            int number = int.Parse(Console.ReadLine());

            int digit1 = (number / 100);
            int digit2 = (number / 10) % 10;
            int digit3 = (number % 10);

            int result = number;

            if(digit1 > digit2 && digit1 > digit3) // Если 1 число больше 2 и 3 числа
            {
                result = digit1 * 100 + Math.Max(digit2, digit3) * 10 + Math.Min(digit2, digit3);
            }
            // То 1 число встает первой с помощью умножения на 100, Math.Max(digit2, digit3) * 10, проверяеться Max число и остаеться в десятках, а Math.Min(digit2,digit3) остаеться в единицах

            else if (digit2 > digit1 && digit2 > digit3)
            {
               result = digit2 * 100 + Math.Max(digit1, digit3) * 10 + Math.Min(digit1,digit3); 
            }
            

            else if (digit3 > digit1 && digit3 > digit2)
            {
                result = digit3 * 100 + Math.Max(digit1, digit2) * 10 + Math.Min(digit1, digit2);
            }

            Console.WriteLine("Result of rearranging numbers: " + result);

        }
    }
}
