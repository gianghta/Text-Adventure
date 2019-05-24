using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Room
    {
        public Dictionary<Direction, Room> roomExits = new Dictionary<Direction, Room>();
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
