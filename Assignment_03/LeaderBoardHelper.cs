using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Cryptography;
using System.Text;

namespace Assignment_03
{
    public static  class LeaderBoardHelper
    {
        #region Exercise 2: Leaderboard
        public static void PrintLeaderBoard(Dictionary<int , string > lb)
        {
            foreach (var player in  lb.OrderByDescending(p => p.Key))
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");

            }
            Console.WriteLine("======================================");
        }
        #endregion 
    }
}
