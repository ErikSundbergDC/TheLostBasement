using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class CommandQuit : Command
    {
        public override string Name 
        { 
            get
            {
                return "Quit";
            }
        }
        public override bool PerformCommand(PlayerCharacter playerCharacter)
        {
            Console.WriteLine("You are leaving the basement!");
            return false;
        }
    }
}

