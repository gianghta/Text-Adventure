using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Inventory
    {
        private List<Item> inventory;

        internal List<Item> PlayerInventory
        {
            get { return inventory; } 
        }

        public Inventory()
        {
            inventory = new List<Item>();
        }
    }
}
