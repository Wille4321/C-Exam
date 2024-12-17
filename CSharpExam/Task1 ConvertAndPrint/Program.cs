using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ConvertAndPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user to enter a integer, a double and a float, Converts all of the users input into numbers
            Console.Write("Enter a Integer value: ");
            int Value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Integer Value is: {Value}");

            Console.Write("Enter a Double value: ");
            double Decimal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Double Value is: {Decimal}");

            Console.Write("Enter a Float value");
            float Float = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Float value is: {Float}");

            Console.Write("Enter a String text: ");
            string String = Console.ReadLine();
            Console.WriteLine($"String Value is: {String}");

            //Outputs the explanations on what they do
            Console.WriteLine("\n Explanations below");
            Console.WriteLine("Int: Stores numbers without ´decimal");
            Console.WriteLine("Double: Stores numbers with decimal and more precise value");
            Console.WriteLine("Float: Stores numbers with decimals and are less precise than double");
            Console.WriteLine("String: Stores a text");

            Console.ReadLine();
        }
    }
}
