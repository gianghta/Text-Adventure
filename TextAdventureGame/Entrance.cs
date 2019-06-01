using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    public enum Directions
    {
        Undefined, North, South, East, West
    };

    class Entrance
    {
        private Room room;
        private Directions direction;

        public Entrance()
        {
            direction = Directions.Undefined;
            room = null;
        }

        public Entrance(Directions nextDirection, Room nextRoom)
        {
            direction = nextDirection;
            room = nextRoom;
        }

        public void SetDirection(Directions nextDirection)
        {
            direction = nextDirection;
        }

        public Directions GetDirection()
        {
            return direction;
        }

        public void SetNextRoom(Room nextRoom)
        {
            room = nextRoom;
        }

        public Room GetNextRoom()
        {
            return room;
        }
    }
}
