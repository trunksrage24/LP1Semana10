using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    /// <summary>
    /// class CompareByName to compare players by their names
    /// </summary>
    public class CompareByName : IComparable<Player>
    {
        //bolean for ordering names
        private bool correct_order;

        //interface to sort by ascendance
        public CompareByName(bool correct_order)
        {
            this.correct_order = correct_order;
        }

        //constructor to return sorted list
        public int CompareTo(Player other)
        {
            if (other == null)
                return 1;

            if (correct_order)
                return string.Compare(Name, other.Name);
            else
                return string.Compare(other.Name, Name);
        }
    }
}
