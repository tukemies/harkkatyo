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
            Console.WriteLine($"{player.PlayerName}'s stats: \nHP: {player.PlayerHealth.ToString()} \n MAX DAMAGE: {player.PlayerDamage.ToString()} \nLevel {player.PlayerLevel.ToString()}");


            while (InCombat == false)
            {
                Console.WriteLine($"What does {player.PlayerName} want to do?\n1. Fight\n2. Leave");
                string PlayerInput = Console.ReadLine();
                if (PlayerInput.Equals("1"))
                {
                    Console.Clear();
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

            while(InCombat == true && goblin.EnemyHealth > 0)
            {
                Console.WriteLine($"Goblin's HP: {goblin.EnemyHealth}/10\n");
                Console.WriteLine($"{player.PlayerName}'s stats:\nHP: {player.PlayerHealth.ToString()}/10 \n");
                Console.WriteLine($"What should {player.PlayerName} do?\n1. Light Attack (Hit for default damage, can't miss)" +
                    $"\n2. Heavy Attack (Can hit up to 3x damage, with a chance to miss.)");
                string PlayerInput = Console.ReadLine();

                if(PlayerInput.Equals("1"))
                {
                    int LightDamage = rnd.Next(1, 3);
                    goblin.EnemyHealth -= LightDamage;
                    Console.Clear();
                    Console.WriteLine($"You hit for {LightDamage.ToString()} damage.");
                }
                else if(PlayerInput.Equals("2"))
                {
                    int HitChance = rnd.Next(1, 21);
                    int HeavyDamage = rnd.Next(4, 7);
                   
                    if(HitChance > 12)
                    {
                        goblin.EnemyHealth -= HeavyDamage;
                        Console.Clear();
                        Console.WriteLine($"You hit for {HeavyDamage.ToString()} damage.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You swing wildly and missed.");
                    }
                }
                player.PlayerHealth -= goblin.EnemyDamage;
                Console.WriteLine($"Goblin hit you for {goblin.EnemyDamage} damage.");

                if(goblin.EnemyHealth <= 0)
                {
                    Console.WriteLine("Congratulations! You have defeated Bob the goblin.");
                }
            }
        }



    }
}
