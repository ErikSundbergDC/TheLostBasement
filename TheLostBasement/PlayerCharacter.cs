using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class PlayerCharacter : Character
    {

        public List<Command> CommandList { get; set; }

        public PlayerCharacter(string name) : base(name)
        {
            CommandList = new List<Command>();
            CommandList.Add(new CommandQuit());
            CommandList.Add(new CommandNorth());
            CommandList.Add(new CommandSouth());
            CommandList.Add(new CommandEast());
            CommandList.Add(new CommandWest());
        }

        public bool PerformCommand()
        {
            bool continueGame = true;
            Console.Write("What do you want to do? ");
            string commandString = Console.ReadLine();
            commandString = commandString.Trim();
            if (commandString.Length > 0)
            {
                
                foreach (Command command in CommandList)
                {
                    if (command.Name.ToLower().StartsWith(commandString.ToLower()))
                    {
                        continueGame = command.PerformCommand(this);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Huh?");
            }
            return continueGame;
        }
    }
}
