using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Dragon : Enemy
    {
        
        public Dragon(int DragonHP)
        {
            Random DragonDmg = new Random();

            EnemyHealth = DragonHP = 100;
            EnemyDamage = DragonDmg.Next(0, 20);
        }
    }
}
