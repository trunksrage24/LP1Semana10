using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    namespace PlayerManager3
    {
    /// <summary>
    /// Implement the generic CompareTo method with the Temperature class as the
    /// Type parameter
    /// </summary>    
        public class Player : IComparable<Player>
        {
            //getter for name
            public string Name { get; }
            //getter for score
            public int Score { get; }

            //Player constructor for name and score
            public Player(string name, int score)
            {
                Name = name;
                Score = score;
            }
            
            //interface CompareTo to sort players by score
            public int CompareTo(Player other)
            {
                if (other == null)
                    return 1;

                return Score.CompareTo(other.Score);
            }
        }
    }
