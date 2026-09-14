using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    internal class CommandSouth : Command
    {
        public override string Name
        {
            get
            {
                return "South";
            }
        }
        public override bool PerformCommand(PlayerCharacter playerCharacter)
        {
            if (playerCharacter.Position.South != null)
            {
                playerCharacter.Position = playerCharacter.Position.South;
            }
            else
            {
                Console.WriteLine("You can't go that way!");
            }
            return true;
        }
    }
}
