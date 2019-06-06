using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    enum Command
    {
        Undefined,
        Look,
        Move,
        Use,
        Run,
        Fight,
        Inventory,
        Help,
    }

    public class GameSession
    {
        public bool isRunning = true;

        private Room currentRoom;
        private Inventory inventory; //Player's inventory
        Dictionary<string, Command> GameCommands;

        public GameSession()
        {
            GameCommands = new Dictionary<string, Command>
            {
                {"use", Command.Use }, {"look", Command.Look}, {"run", Command.Run},
                {"fight", Command.Fight}, {"move", Command.Move},
                {"inventory", Command.Inventory }, {"help", Command.Help}
            };

            Room firstRoom = new Room("Entrance Cave", "A dark gritty cave that smell like dead fish as the light slowly fade behind your back when you entered");
            Room secondRoom = new Room("Second room", "This is the second room that has one entrance to the West and one entrance to the East");
            Room thirdRoom = new Room("Third room on the West Entrance of second room", "Test description");
            Room fourthRoom = new Room("Fourth room on the East Entrance of second room", "Test Description");

            firstRoom.AddEntrance(new Entrance(Directions.South, secondRoom));

            secondRoom.AddEntrance(new Entrance(Directions.North, firstRoom));
            secondRoom.AddEntrance(new Entrance(Directions.West, thirdRoom));
            secondRoom.AddEntrance(new Entrance(Directions.East, fourthRoom));

        }

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

        public static void StartGame()
        {
            Title();
            Intro();
        }

        public void Update()
        {
            string currentCommand = Console.ReadLine().ToLower();

            if (currentCommand == "quit" || currentCommand == "q")
            {
                isRunning = false;
                return;
            }
            StartGame();
        }
    }
}
