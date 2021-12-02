using System;

namespace HarjoitusTyö
{
    class Program
    {


        static void Main(string[] args)
        {

            Character player = new Character(10, 2, 1);
            Goblin goblin = new Goblin(10, 2);
            Console.WriteLine($"Goblin's stats are {goblin.GetStats()}");

            Console.WriteLine("Insert your name.");
            player.SetPlayerName();
            Console.WriteLine($"{player.PlayerName}'s stats: \nHP: {player.PlayerHealth.ToString()} \nDAMAGE: {player.PlayerDamageBase.ToString()} \nLevel {player.PlayerLevel.ToString()}");



            while(InCombat == true)
            {

            }
            
        }
    }
}
