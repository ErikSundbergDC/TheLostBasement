using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    abstract internal class Character
    {
        public string Name { get; set; }

        private Room position;

        public Room Position
        {
            get 
            { 
                return position; 
            }
            set 
            {
                if (position != null)
                {
                    position.characters.Remove(this);
                }
                position = value;
                position.characters.Add(this);
            }
        }


        public Character(string name)
        {
            Name = name;
        }
    }
}
