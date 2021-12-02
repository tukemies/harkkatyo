using System;
using System.Collections.Generic;
using System.Text;

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



        public Character(int playerHP, int playerDmg, int playerLvl) 
        {
            PlayerHealth = playerHP;
            PlayerDamage = playerDmg;
            PlayerLevel = playerLvl;
        }


    }
}
