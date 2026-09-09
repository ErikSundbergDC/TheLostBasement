using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class PlayerCharacter
    {
        public string Name { get; set; }

        public Room Position { get; set; }

        public List<Command> CommandList { get; set; }

        public PlayerCharacter(string name)
        {
            Name = name;
            CommandList = new List<Command>();
            CommandList.Add(new CommandQuit());
            CommandList.Add(new CommandNorth());
        }

        public bool PerformCommand()
        {
            Console.Write("What do you want to do? ");
            string commandString = Console.ReadLine();

            bool continueGame = true;
            foreach (Command command in CommandList)
            {
                if (command.Name.ToLower() == commandString.ToLower())
                {
                    continueGame = command.PerformCommand(this);
                    break;
                }
            }

            return continueGame;
        }
    }
}
