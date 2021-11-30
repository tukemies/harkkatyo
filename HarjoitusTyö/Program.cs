using System;

namespace HarjoitusTyö
{
    class Program
    {


        static void Main(string[] args)
        {
            bool InCombat = false;
            Character player = new Character(10, 2, 1);

            Console.WriteLine("Insert your name.");
            player.SetPlayerName();
            Console.WriteLine($"{player.PlayerName}'s stats: \nHP: {player.PlayerHealth.ToString()} \nDAMAGE: {player.PlayerDamageBase.ToString()} \nLevel {player.PlayerLevel.ToString()}");


            while(InCombat == true)
            {

            }
            
        }
    }
}
