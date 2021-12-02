using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Dragon : Enemy
    {
        public Dragon(int EnemyHp, int EnemyDMG, string eName)
        {
            EnemyHealth = EnemyHp;
            EnemyDamage = EnemyDMG;
            EnemyName = eName;
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
