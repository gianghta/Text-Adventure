using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Player
    {
        public string Name { get; set; }
        public int HealthPoint { get; set; }
        public List<Item> Inventory { get; private set; }

        public Player()
        {
            Name = "null";
            HealthPoint = 200;
            Inventory = new List<Item>();
        }
    }
}
