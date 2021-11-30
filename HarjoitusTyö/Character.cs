using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Character
    {
        public int PlayerHealth;
        public int PlayerDamageBase;
        public string PlayerName;
        public int PlayerLevel;
        Random rng = new Random();

       public enum AttackTypes
        {
            LightAttack,
            HeavyAttack
        }


        public Character() {}

        public string SetPlayerName()
        {
            PlayerName = Console.ReadLine();
            return PlayerName;
        }

        public Character(int playerHP, int playerDmgB, int playerLvl) 
        {
            PlayerHealth = playerHP;
            PlayerDamageBase = playerDmgB;
            PlayerLevel = playerLvl;
        }
    }
}
