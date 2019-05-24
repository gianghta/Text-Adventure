/*
 * Text Adventure game
 * by Giang Ta, May 23 2019
 * 
 * The game storyline and scenario
 * is inspired by Goblin Slayer manga
 * with a bit mix of Dungeon & Dragon setup
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

    class Program
    {
        static void Main(string[] args)
        {
            GameSession.StartGame();
            Console.Read();
        }
    }
}
