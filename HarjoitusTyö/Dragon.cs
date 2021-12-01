using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Dragon : Enemy
    {
        public Dragon() { }
        
        public override void SetStats(int EnemyHP, int EnemyDMG, string eName)
        {
            EnemyHealth = EnemyHP;
            EnemyDamage = EnemyDMG;
            EnemyName = eName;
        }
    }
}
