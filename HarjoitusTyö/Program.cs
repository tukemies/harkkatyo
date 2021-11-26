using System;

namespace HarjoitusTyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Goblin's health is {}");
            Console.WriteLine("Insert your name.");
            Character player = new Character(10, 2, 1);
            player.SetPlayerName();
            Console.WriteLine($"Your name is {player.PlayerName}");
            Console.WriteLine($"Here is your health: {player.PlayerHealth.ToString()}, and here is your damage {player.PlayerDamage.ToString()}. You're currently level {player.PlayerLevel.ToString()}");

        }
    }
}
