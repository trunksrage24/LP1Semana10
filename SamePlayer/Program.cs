﻿using System;
using System.Collections.Generic;

namespace SamePlayer
{
    public enum PlayerType { Tank, Fighter, Slayer, Mage, Controller, Marksmen }

    /// <summary>
    /// class Program that cretaes new players and gives them types
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            //HashSet list to save player names and types
            HashSet<Player> setOfPlayers = new HashSet<Player>
            {
                new Player { Type = PlayerType.Tank, Name = "Ana" },
                new Player { Type = PlayerType.Slayer, Name = "Paulo" },
                new Player { Type = PlayerType.Tank, Name = "Ana" }
            };
            Console.WriteLine("Number of players in the set: " + setOfPlayers.Count);
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}");
            }
        }
    }
}