using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamePlayer
{
    /// <summary>
    /// Player class to compare players with
    /// </summary>
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public override int GetHashCode() => HashCode.Combine(Type, Name);
        
        public override bool Equals(object obj) => obj is Player otherPlayer && Type == otherPlayer.Type && Name == otherPlayer.Name;
    }
}