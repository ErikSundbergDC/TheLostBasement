using System;
using System.Collections.Generic;
using System.Text;

namespace TheLostBasement
{
    
    abstract internal class Command
    {
        public abstract string Name { get; }
        public abstract bool PerformCommand(PlayerCharacter playerCharacter);
    }
}
