using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Room
    {
        internal string RoomName { get; set; }
        internal string RoomDescription { get; set; }
        private List<Entrance> entrances;

        public Room()
        {
            RoomName = "";
            RoomDescription = "";
            entrances = new List<Entrance>();
        }

        public Room(string title)
        {
            RoomName = title;
            RoomDescription = "";
            entrances = new List<Entrance>();
        }

        public Room(string title, string description)
        {
            RoomName = title;
            RoomDescription = description;
            entrances = new List<Entrance>();
        }

        public void AddEntrance(Entrance newEntrance)
        {
            entrances.Add(newEntrance);
        }

        public void RemoveEntrance(Entrance currentEntrance)
        {
            if (entrances.Contains(currentEntrance))
            {
                entrances.Remove(currentEntrance);
            }
        }

        public List<Entrance> GetEntranceList()
        {
            return new List<Entrance>(entrances);
        }
    }
}
