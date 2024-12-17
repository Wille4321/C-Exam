using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_ArraysLoopsAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two arrays with 1 containing names and the other containing numbers
            string[] name = {"bob", "Steve", "Nina"};

            int[] num = {5, 57, 87, 1, 150, 32, 14};

            //A loop that prints out the names with a goodbye before them
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Goodbye " + name[i]);
            }

            //A sort that sorts the numbers in ascending order and removes the last element
            Array.Sort(num);

            num = num.Take(num.Length - 1).ToArray();
            
            Console.WriteLine("\nSorted numbers without the last element: ");
            Console.WriteLine(string.Join(",", num));

            Console.ReadLine();
        }
    }
}
