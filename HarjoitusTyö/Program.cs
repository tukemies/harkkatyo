using System;

namespace HarjoitusTyö
{
    class Program
    {


        static void Main(string[] args)
        {
            bool InCombat = false;

            Random rnd = new Random();
            Character player = new Character(10, 2, 1);
            Goblin goblin = new Goblin(10, 2);

            Console.WriteLine("Insert your character's name:");
            player.SetPlayerName();

            Console.Clear();
            Console.WriteLine($"{player.PlayerName}'s stats: \nHP: {player.PlayerHealth.ToString()} \nDAMAGE: {player.PlayerDamageBase.ToString()} \nLevel {player.PlayerLevel.ToString()}");


            while (InCombat == false)
            {
                Console.WriteLine($"What does {player.PlayerName} want to do?\n1. Fight\n2. Leave");
                string PlayerInput = Console.ReadLine();
                if (PlayerInput.Equals("1"))
                {
                    InCombat = true;
                }
                else if (PlayerInput.Equals("2"))
                {
                    Console.WriteLine($"{player.PlayerName} tries to leave, but there is nowhere to run.");
                }
                else
                {
                    Console.WriteLine($"{player.PlayerName} forgot what he was supposed to do.");
                }
            }

            while(InCombat == true)
            {
                Console.WriteLine($"Goblin's stats are {goblin.GetStats()}\n");
                Console.WriteLine($"{player.PlayerName}'s stats:\nHP: {player.PlayerHealth.ToString()} \nDAMAGE: {player.PlayerDamageBase.ToString()} \nLevel {player.PlayerLevel.ToString()}\n");
                Console.WriteLine($"What should {player.PlayerName} do?\n1. Light Attack\n2. Heavy Attack");
                string PlayerInput = Console.ReadLine();
            }
        }
    }
}
