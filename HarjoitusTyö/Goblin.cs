using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Goblin : Enemy
    {
        public Goblin() { }
        public Goblin(int GoblinHP)
        {
            Random GoblinDmg = new Random();

            EnemyHealth = GoblinHP = 10;
            EnemyDamage = GoblinDmg.Next(0, 2);
        }
    }
}
