using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Goblin : Enemy
    {
        public Goblin() { }

        public override void SetStats(int EnemyHP, int EnemyDMG, string eName)
        {
            EnemyHealth = EnemyHP;
            EnemyDamage = EnemyDMG;
            EnemyName = eName;
        }
    }
}
