using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_PositiveOrNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user to input any number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            double num;

            //An if that says if the number is Positive, Negative or the number Zero
            if (double.TryParse(input, out num))
            {
                if(num > 0)
                {
                    Console.WriteLine("The number is Positive");
                }
                else if(num < 0)
                {
                    Console.WriteLine("The number is Negative");
                }
                else
                {
                    Console.WriteLine("The number is zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
