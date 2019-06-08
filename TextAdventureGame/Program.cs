/*
 * Text Adventure game
 * by Giang Ta, May 23 2019
 * 
 * A text RPG made in free time
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSession game = new GameSession();

            while (game.isRunning)
            {
                game.Update();
            }
        }
    }
}
