using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Bear : Enemy
    {
        Random EnemyDmg = new Random();
         public Bear()
        {
            EnemyHealth = 20;
            EnemyDamage = EnemyDmg.Next(0, 7);
        }
    }
}
