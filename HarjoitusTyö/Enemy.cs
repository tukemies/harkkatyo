using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    abstract class Enemy
    {
        public int EnemyHealth;
        public int EnemyDamage;
        public string EnemyName;

        public abstract void SetStats(int EnemyHP, int EnemyDMG, string eName);

        public string GetStats()
        {
            string stats = ($"{EnemyName}\nHP:{EnemyHealth.ToString()}\nDamage: {EnemyDamage.ToString()}");
            return stats;
        }

    }
}
