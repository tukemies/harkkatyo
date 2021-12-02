using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Goblin : Enemy
    {
        public Goblin(int EnemyHp, int EnemyDMG)
        {
            EnemyHealth = EnemyHp;
            EnemyDamage = EnemyDMG;
        }

        public override void SetStats(int EnemyHP, int EnemyDMG, string eName)
        {
            EnemyHealth = EnemyHP;
            EnemyDamage = EnemyDMG;
            EnemyName = eName;
        }

        public override string GetStats()
        {
            string stats = ($"{EnemyName}\nHP:{EnemyHealth.ToString()}\nDamage: {EnemyDamage.ToString()}");
            return stats;
        }

    }
}
