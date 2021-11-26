using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Dragon : Enemy
    {
        Random EnemyDmg = new Random();

        public Dragon()
        {
            EnemyHealth = 100;
            EnemyDamage = EnemyDmg.Next(0, 20);
        }
        
    }
}
