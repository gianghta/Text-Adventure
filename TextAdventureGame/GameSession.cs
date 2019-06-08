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
        Inventory,
        Help,
    }

    public class GameSession
    {
        public bool isRunning = true;

        Room currentRoom;

        private List<Item> inventory;

        Dictionary<string, Command> GameCommands;

        public GameSession()
        {
            inventory = new List<Item>();

            GameCommands = new Dictionary<string, Command>
            {
                {"use", Command.Use }, {"look", Command.Look}, {"move", Command.Move},
                {"inventory", Command.Inventory }, {"help", Command.Help}
            };

            Room firstRoom = new Room("Entrance Cave", "A dark gritty cave that reeks of blood" +
                " as the light slowly fade behind your back when you entered." +
                "You can barely see anything ahead except for a door to the South");
            Item key = new Item("rusty key", "A small copper key that seems to open something");

            Room secondRoom = new Room("Even darker cave", "An even darker cave that has one entrance to the West" +
                " and one entrance to the East. The smell of blood is getting stronger, sending chill down your spine");
            Item dagger = new Item("A metal dagger", "A dagger with blood stain on it, doesn't seem like it belongs to human");

            Room thirdRoom = new Room("Third room on the West Entrance of second room", "Game room under construction!!");
            Room fourthRoom = new Room("Fourth room on the East Entrance of second room", "Game room under construction!!");

            firstRoom.AddEntrance(new Entrance(Directions.South, secondRoom));

            secondRoom.AddEntrance(new Entrance(Directions.North, firstRoom));
            secondRoom.AddEntrance(new Entrance(Directions.West, thirdRoom));
            secondRoom.AddEntrance(new Entrance(Directions.East, fourthRoom));

            currentRoom = firstRoom;

            Title();
            Intro();
        }

        static void Title()
        {
            string Title = @"   ____        _       __  __                  ___       __                 __                
   / __ \____  (_)___  / /_/ /__  __________   /   | ____/ /   _____  ____  / /___  __________ 
  / /_/ / __ \/ / __ \/ __/ / _ \/ ___/ ___/  / /| |/ __  / | / / _ \/ __ \/ __/ / / / ___/ _ \
 / ____/ /_/ / / / / / /_/ /  __(__  |__  )  / ___ / /_/ /| |/ /  __/ / / / /_/ /_/ / /  /  __/
/_/    \____/_/_/ /_/\__/_/\___/____/____/  /_/  |_\__,_/ |___/\___/_/ /_/\__/\__,_/_/   \___/ 
                                                                                               ";
            Console.WriteLine("WELCOME TO");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Text Adventure";
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A text adventure game made during free time");
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
