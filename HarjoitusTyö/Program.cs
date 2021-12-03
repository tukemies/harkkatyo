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
            Character player = new Character(10, 3, 1);
            Goblin goblin = new Goblin(10, 2, "Bob the Goblin");

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
                                  $"MAX DAMAGE: {player.PlayerDamage - 1} \n" +
                                  $"Character Level {player.PlayerLevel.ToString()}");

                while (InCombat == false)
                {
                    Console.WriteLine($"What does {player.PlayerName} want to do?\n1. Fight\n2. Leave");
                    string PlayerInput = Console.ReadLine();
                    if (PlayerInput.Equals("1"))
                    {
                        Console.Clear();
                        InCombat = true;
                        Console.WriteLine($"{goblin.EnemyName} challenges you.");
                    }
                    else if (PlayerInput.Equals("2"))
                    {
                        Console.Clear();
                        Console.WriteLine($"{player.PlayerName} tries to leave, but there is nowhere to run.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{player.PlayerName} forgot what he was supposed to do.");
                    }
                }

                while (InCombat == true)
                {
                    while (goblin.EnemyHealth > 0 && player.PlayerHealth > 0)
                    {
                        Console.WriteLine($"{goblin.EnemyName}'s HP: {goblin.EnemyHealth}/10\n");
                        Console.WriteLine($"{player.PlayerName}'s stats:\nHP: {player.PlayerHealth.ToString()}/10 \n");
                        Console.WriteLine($"What should {player.PlayerName} do?\n1. Light Attack (Hit for default damage, can't miss)" +
                                          $"\n2. Heavy Attack (Can hit up to 3x damage, with a chance to miss.)");

                        string PlayerInput = Console.ReadLine();

                        if (PlayerInput.Equals("1"))
                        {
                            int LightDamage = rnd.Next(1, player.PlayerDamage);
                            goblin.EnemyHealth -= LightDamage;
                            Console.Clear();
                            Console.WriteLine($"{player.PlayerName} hit for {LightDamage.ToString()} damage.");
                        }
                        else if (PlayerInput.Equals("2"))
                        {
                            int HitChance = rnd.Next(1, 21);
                            int HeavyDamage = player.PlayerDamage * 2;

                            if (HitChance > 12)
                            {
                                goblin.EnemyHealth -= HeavyDamage;
                                Console.Clear();
                                Console.WriteLine($"{player.PlayerName} hits for {HeavyDamage.ToString()} damage.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"{player.PlayerName} swings wildly and misses.");
                            }
                        }

                        player.PlayerHealth -= goblin.EnemyDamage;
                        Console.WriteLine($"{goblin.EnemyName} hit {player.PlayerName} for {goblin.EnemyDamage} damage.");

                        if (goblin.EnemyHealth <= 0)
                        {
                            Console.WriteLine($"Congratulations! {player.PlayerName} has defeated {goblin.EnemyName}, his family will probably miss him.");
                            player.PlayerLevel = 2;
                            Console.WriteLine($"{player.PlayerName} is now level {player.PlayerLevel}");
                            player.PlayerHealth = 20;
                            player.PlayerDamage = 4;
                            InCombat = false;
                        }
                        else if (player.PlayerHealth <= 0)
                        {
                            Console.WriteLine($"Game over! {player.PlayerName} has died, how tragic.");
                            InCombat = false;
                            Playing = false;
                        }

                    }

                    while (player.PlayerHealth > 0 && InCombat == false)
                    {
                        Console.WriteLine("Do you wish to keep going? Y/N");
                        string UserInput = Console.ReadLine();
                        if (UserInput.Trim().ToLower().Equals("y"))
                        {
                            InCombat = true;
                        }
                        else if (UserInput.Trim().ToLower().Equals("n"))
                        {
                            Console.WriteLine("Good game!");
                            Playing = false;
                            break;
                        }
                    }

                    while (InCombat == true && Playing == true && player.PlayerHealth > 0)
                    {
                        Console.WriteLine("A honey addicted bear walks in.\nYou raise your fists.");
                        Console.ReadLine();
                    }
                }
            }

        }

    }
}
