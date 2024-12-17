using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4_FixTheCode
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Asks user to enter 2 numbers
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();

                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine();

                double num1, num2;

                //The if does the math and answers if the input was invalid
                if (double.TryParse(input1, out num1) && double.TryParse(input2, out num2))
                {
                    double sum = Add(num1, num2);
                    double difference = Subtract(num1, num2);
                    double product = Multiply(num1, num2);
                    string quotient = Divide(num1, num2);

                    Console.WriteLine($"The sum of the numbers is: {sum}");
                    Console.WriteLine($"The difference of the numbers is: {difference}");
                    Console.WriteLine($"The product of the numbers is: {product}");
                    Console.WriteLine($"The quotient of the numbers is: {quotient}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }

                Console.ReadLine();
            }
            
            //static doubles that make the Add, Subtract, Multiply and Divide work
            static double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            static double Subtract(double num1, double num2)
            {
                return num1 - num2;
            }

            static double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            static string Divide(double num1, double num2)
            {
                if (num2 == 0)
                {
                    //Outputs if you put 0 as one of the numbers
                    return "Cannot divide by zero";
                }
                return (num1 / num2).ToString();
            }
        }
    }
