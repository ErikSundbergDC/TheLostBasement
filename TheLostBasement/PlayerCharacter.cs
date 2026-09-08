using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class PlayerCharacter
    {
        public string Name { get; set; }

        public List<Command> CommandList { get; set; }

        public PlayerCharacter(string name)
        {
            Name = name;
            CommandList = new List<Command>();
            CommandList.Add(new CommandQuit());
        }

        public bool PerformCommand()
        {
            Console.Write("What do you want to do? ");
            string commandString = Console.ReadLine();

            bool continueGame = true;
            foreach (Command command in CommandList)
            {
                if (command.Name == commandString)
                {
                    continueGame = command.PerformCommand();
                    break;
                }
            }

            return continueGame;
        }
    }
}
