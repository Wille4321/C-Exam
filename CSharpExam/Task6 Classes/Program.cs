using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a list
            List<Game>games = new List<Game>();

            //Add games to the list
            Game game1 = new Game("Bloons 6", "Ninja Kiwi", "2018", "Tower Defense");
            games.Add(game1);
            Console.WriteLine(".");

            Game game2 = new Game("Minecraft", "Mojang", "2009", "Survival");
            games.Add(game2);

            //Prints out the list
            Console.WriteLine("Game list:");
            foreach (Game game in games)
            {
                game.DisplayInfo();
            }

            Console.ReadLine();
        }
    }

    
    class Game
    {
        //class properties
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }


        public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }

        //class that makes the output show
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Publisher: {Publisher}, Year: {Year}, Genre: {Genre}");
        }
    }
}


