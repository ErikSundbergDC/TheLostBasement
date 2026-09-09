using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class CommandNorth : Command
    {
        public override string Name
        {
            get
            {
                return "North";
            }
        }
        public override bool PerformCommand(PlayerCharacter playerCharacter)
        {
            if(playerCharacter.Position.North != null)
            {
                playerCharacter.Position = playerCharacter.Position.North;
            }
            else
            {
                Console.WriteLine("You can't gp that way!");
            }
            return true;
        }
    }
}
