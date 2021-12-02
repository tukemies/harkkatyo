using System;

namespace HarjoitusTyö
{
    class Program
    {


        static void Main(string[] args)
        {
            bool InCombat = false;
            bool Playing = false;
            Random rnd = new Random();
            Character player = new Character(10, 2, 1);
            Goblin goblin = new Goblin(10, 2);

            while (Playing == false)
            {
                Console.WriteLine("The Arena \n" +
                "1. Play\n" +
                "2. Quit");
                string UserInput = Console.ReadLine();

                if (UserInput.Equals("1"))
                {
                    Console.Clear();
                    Playing = true;
                }
                else if (UserInput.Equals("2"))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Unknown command.\n");
                    
                }
            }
            while (Playing == true)
            {
                Console.WriteLine("Welcome to the Arena!\n");
                Console.WriteLine("Insert a name for your character:");
                player.SetPlayerName();

                Console.Clear();
                Console.WriteLine($"{player.PlayerName}'s stats: \n" +
                    $"HP: {player.PlayerHealth.ToString()} \n" +
                    $"MAX DAMAGE: {player.PlayerDamage.ToString()} \n" +
                    $"Level {player.PlayerLevel.ToString()}");


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

                while (InCombat == true && goblin.EnemyHealth > 0)
                {
                    Console.WriteLine($"Goblin's HP: {goblin.EnemyHealth}/10\n");
                    Console.WriteLine($"{player.PlayerName}'s stats:\nHP: {player.PlayerHealth.ToString()}/10 \n");
                    Console.WriteLine($"What should {player.PlayerName} do?\n1. Light Attack (Hit for default damage, can't miss)" +
                        $"\n2. Heavy Attack (Can hit up to 3x damage, with a chance to miss.)");
                    string PlayerInput = Console.ReadLine();

                    if (PlayerInput.Equals("1"))
                    {
                        int LightDamage = rnd.Next(1, 3);
                        goblin.EnemyHealth -= LightDamage;
                        Console.Clear();
                        Console.WriteLine($"You hit for {LightDamage.ToString()} damage.");
                    }
                    else if (PlayerInput.Equals("2"))
                    {
                        int HitChance = rnd.Next(1, 21);
                        int HeavyDamage = rnd.Next(4, 7);

                        if (HitChance > 12)
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

                    if (goblin.EnemyHealth <= 0)
                    {
                        Console.WriteLine("Congratulations! You have defeated Bob the goblin, his family will probably miss him.");
                    }
                    if (player.PlayerHealth <= 0)
                    {
                        InCombat = false;
                        Console.WriteLine("Game over! You have died, how tragic.");
                        Playing = false;
                    }

                }

            }

        }

    }
}
