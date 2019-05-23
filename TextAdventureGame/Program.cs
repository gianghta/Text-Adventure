/*
 * Text Adventure game
 * by Giang Ta, May 23 2019
 * 
 * The game storyline and scenario
 * is inspired by Goblin Slayer manga
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace TextAdventureGame
{
    enum Direction
    {
        North,
        South,
        West,
        East
    }

    class Room
    {
        public Dictionary<Direction, Room> exits = new Dictionary<Direction, Room>();
        public string name;
        public string description;
    }

    class Items
    {

    }

    class Character
    {
        string Name { get; set; }
        string Level { get; set; }
    }

    class Enemy
    {
        string EnemyName { get; set; }
        float combatPower;
    }

    public static class GameSession
    {
        static void Title()
        {
            string Title = @" _____         _      _  
_          _____  _                           
|  __ \       | |    | |(_)        /  ___|| |                          
| |  \/  ___  | |__  | | _  _ __   \ `--. | |  __ _  _   _   ___  _ __ 
| | __  / _ \ | '_ \ | || || '_ \   `--. \| | / _` || | | | / _ \| '__|
| |_\ \| (_) || |_) || || || | | | /\__/ /| || (_| || |_| ||  __/| |   
 \____/ \___/ |_.__/ |_||_||_| |_| \____/ |_| \__,_| \__, | \___||_|   
                                                      __/ |            
                                                     |___/             ";
            Console.WriteLine("WELCOME TO");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Goblin Slayer";
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A text adventure game inspired by a Japanese manga");
            Console.ResetColor();
            Console.WriteLine("\n.......Press enter to start........");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public static void StartGame()
        {
            Title();
        }

        /*
         * Reference code to learn/study
         * and apply to my own game
         * These are taken from the Internet
         * 
        static void Describe(Room room)
        {
            string exitsText = string.Join(", ", room.exits.Keys.ToArray());
            if (string.IsNullOrEmpty(exitsText))
            {
                exitsText = "None";
            }
            Console.WriteLine("{0}\n\n{1}\n\nExits Are: {2}\n", room.name, room.description, exitsText);
        }

        static Room Setup()
        {
            Room main = new Room() { name = "Main", description = "This is the main room." };
            Room eastWing = new Room() { name = "East Wing", description = "This is the east wing." };
            Room closet = new Room() { name = "Closet", description = "This is a closet.  The door locked behind you." };
            Room passage = new Room() { name = "Secret passage", description = "This is a long secret passage." };
            Room vestibule = new Room() { name = "Vestibule", description = "This is a vestibule." };

            main.exits.Add(Direction.East, eastWing);
            main.exits.Add(Direction.West, closet);
            eastWing.exits.Add(Direction.West, main);
            closet.exits.Add(Direction.West, passage);
            passage.exits.Add(Direction.North, closet);
            passage.exits.Add(Direction.East, vestibule);
            vestibule.exits.Add(Direction.West, passage);
            vestibule.exits.Add(Direction.South, main);

            return main;

        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameSession.StartGame();
            Console.Read();
        }
    }
}
