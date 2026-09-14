using System;
using System.Collections.Generic;
using System.Text;



namespace TheLostBasement
{
    internal class Room
    {
        public List<Character> characters = new List<Character>();

        public string Name { get; private set; }
        public string Description { get; set; }

        public Room North { get; set; }
        public Room East { get; set; }
        public Room South { get; set; }
        public Room West { get; set; }

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
        }

        private static string UnderLine(string text)
        {
            string line = "";
            for (int i = 0; i < text.Length; i++)
            {
                line = line + "~";
            }
            return line;
        }

        private void DisplayExits()
        {
            Console.Write("Exits: ");
            if(North != null)
            {
                Console.Write("North ");
            }
            if (East != null)
            {
                Console.Write("East ");
            }
            if (South != null)
            {
                Console.Write("South ");
            }
            if (West != null)
            {
                Console.Write("West ");
            }
            Console.WriteLine();
        }

        private void DisplayCharacters()
        {
            foreach (Character character in characters)
            {
                Console.WriteLine(character.Name + " is here.");
            }
        }

        public void Display()
        {
            
            Console.WriteLine(Name);
            Console.WriteLine(UnderLine(Name));
            Console.WriteLine();
            Console.WriteLine(Description);
            Console.WriteLine();
            DisplayCharacters();
            Console.WriteLine();
            DisplayExits();

        }
    }
}
