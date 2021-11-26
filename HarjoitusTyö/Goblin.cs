using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Goblin : Enemy
    {
        Random EnemyDmg = new Random();
        public Goblin()
        {
            EnemyHealth = 10;
            EnemyDamage = EnemyDmg.Next (0, 2);
        }
    }
}
