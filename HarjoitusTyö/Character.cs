using System;
using System.Collections.Generic;
using System.Text;

//Author: Tuukka Tenhunen
namespace HarjoitusTyö
{
    class Character
    {
        public int PlayerHealth;
        public int PlayerDamage;
        public string PlayerName;
        public int PlayerLevel;

        public Character() {}

        public string SetPlayerName()
        {
            PlayerName = Console.ReadLine();
            return PlayerName;
        }



        public Character(int playerHp, int playerDmg, int playerLvl) 
        {
            PlayerHealth = playerHp;
            PlayerDamage = playerDmg;
            PlayerLevel = playerLvl;
        }

    }
}
