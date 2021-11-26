using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Character
    {
        public int playerHealth;
        public int playerDamage;
        public enum attackTypes
        {
            Light,
            Heavy
        }

        public Character() {}

        public Character(int playerHP, int playerDmg) 
        {
            playerHealth = playerHP;
            playerDamage = playerDmg;
        }
    }
}
