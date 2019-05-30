using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Item
    {
        private string _name;
        private string _description;

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }

        public Item()
        {
            _name = "";
            _description = "";
        }

        public Item(string title)
        {
            _name = title;
            _description = "";
        }

        public Item(string title, string description)
        {
            _name = title;
            _description = description;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
