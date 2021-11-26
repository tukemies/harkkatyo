using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    class Bear : Enemy
    {
        
         public Bear( int BearHP)
        {
            Random BearDmg = new Random();

            EnemyHealth = BearHP = 20;
            EnemyDamage = BearDmg.Next(0, 7);
        }
    }
}
