using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    enum Direction
    {
        North,
        South,
        West,
        East
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

        static void Intro()
        {
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("This is the first part of the story");
            Console.WriteLine("Press any keys to continue");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }

        static void DescribeRoom(Room room)
        {
            string exitsText = string.Join(", ", room.roomExits.Keys.ToArray());
            if (string.IsNullOrEmpty(exitsText))
            {
                exitsText = "None";
            }
            Console.WriteLine("{0}\n\n{1}\n\nExits Are: {2}\n", room.Name, room.Description, exitsText);
        }

        static void CreatePlayer()
        {
            var player = new Player();
            Console.Write("Please tell us your name, great adventurer: ");
            player.Name = Console.ReadLine();
            Console.WriteLine("So, your name is {0}", player.Name);
        }

        public static void StartGame()
        {
            Title();
            Intro();
            Room main = new Room() { Name = "Main", Description = "This is the main room." };
            CreatePlayer();
            DescribeRoom(main);
        }

        /*
         * Reference code to learn/study
         * and apply to my own game
         * These are taken from the Internet
         * 
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
}
