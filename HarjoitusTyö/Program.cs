using System;

namespace HarjoitusTyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your name.");
            Character player = new Character(10, 2);
            player.SetPlayerName();
            Console.WriteLine($"Your name is {player.PlayerName}");
        }
    }
}
