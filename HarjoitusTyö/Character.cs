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
    public class Attack : IAction
    {
        public string AttackType;

        public void Action(Attack lAttack, Attack hAttack)
        {
            if (AttackType == "Light")
            {
                Console.WriteLine("You attacked enemy for 2 damage!");
            }
            if (AttackType == "Heavy")
            {
                Console.WriteLine("You attacked enemy for 4 damage!");
            }

        }
    }
}
