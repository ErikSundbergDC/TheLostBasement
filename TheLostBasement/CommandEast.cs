using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class CommandEast : Command
    {
        public override string Name
        {
            get
            {
                return "East";
            }
        }
        public override bool PerformCommand(PlayerCharacter playerCharacter)
        {
            if (playerCharacter.Position.East != null)
            {
                playerCharacter.Position = playerCharacter.Position.East;
            }
            else
            {
                Console.WriteLine("You can't go that way!");
            }
            return true;
        }
    }
}
