using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class CommandWest : Command
    {
        public override string Name
        {
            get
            {
                return "West";
            }
        }
        public override bool PerformCommand(PlayerCharacter playerCharacter)
        {
            if (playerCharacter.Position.West != null)
            {
                playerCharacter.Position = playerCharacter.Position.West;
            }
            else
            {
                Console.WriteLine("You can't go that way!");
            }
            return true;
        }
    }
}