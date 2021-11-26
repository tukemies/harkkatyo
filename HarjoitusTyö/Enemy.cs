using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Enemy
    {
        public int EnemyHealth;
        public int EnemyDamage;
        public int EnemyStats(int EnemyHP, int EnemyDmg)
        {
            EnemyHealth = EnemyHP;
            EnemyDamage = EnemyDmg;
            return EnemyHP;
            return EnemyDmg;
        }
        
    }
}
