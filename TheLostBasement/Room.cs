using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class Room
    {
        public string Name { get; private set; }
        public string Description { get; set; }

        public Room North { get; set; }

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
