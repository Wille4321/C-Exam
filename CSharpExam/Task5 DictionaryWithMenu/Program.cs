using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_DictionaryWithMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The dictionary
            Dictionary<string, string> Words = new Dictionary<string, string>();

            //Asks user to input a number from the menu
            while(true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a word and a description");
                Console.WriteLine("2. Remove a word");
                Console.WriteLine("3. Show all words and thier desctiption");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choise of option: ");

                string input = Console.ReadLine();

                //The Switch Case for the menu
                switch(input)
                {
                    //Adds a word with a description
                    case "1":
                        Console.WriteLine("Enter a word: ");
                        string word = Console.ReadLine();

                        if(Words.ContainsKey(word))
                        {
                            Console.WriteLine("This word already exists. Do you want to overwrite the word (Yes/No): ");
                            string overwrite = Console.ReadLine()?.ToLower();

                            if(overwrite != "Yes")
                            {
                                Console.WriteLine("Word not overwrited");
                                break;
                            }
                        }
                        Console.WriteLine("Enter a description: ");
                        string description = Console.ReadLine();
                        Words[word] = description;
                        Console.WriteLine("Word Added/Updated Succesfully");

                        break;

                        //Removes a word
                    case "2":
                        Console.Write("Enter the word to remove: ");
                        string wordToRemove = Console.ReadLine();
                        if (Words.Remove(wordToRemove))
                        {
                            Console.WriteLine("Word removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Word not found.");
                        }
                        break;

                        //Shows all the words and thier description
                    case "3":
                        if (Words.Count == 0)
                        {
                            Console.WriteLine("Dictionary is empty");
                        }
                        else
                        {
                            Console.WriteLine("Words and their definitions:");
                            foreach (var entry in Words)
                            {
                                Console.WriteLine($"{entry.Key}: {entry.Value}");
                            }
                        }
                        break;

                        //Exits the program
                    case "4":
                        Console.WriteLine("See you later alligator :)");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                Console.ReadLine();
            }
           
        }
    }
}
