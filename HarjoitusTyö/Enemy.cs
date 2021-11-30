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

    }
}
