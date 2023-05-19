using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    /// <summary>
    /// class CompareByName to compare players by their names
    /// </summary>
    public class CompareByName : IComparer<Player>
    {
        private readonly bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            //Compare players based on their names
            int result = string.Compare(x.Name, y.Name);

            //Reverse the result if the sorting order is descending
            if (!ascending)
                result *= -1;

            return result;
        }
    }
}
