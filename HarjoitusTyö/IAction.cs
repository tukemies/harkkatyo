using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyö
{
    interface IAction
    {
        public void Action(Attack lAttack, Attack hAttack);
    }
}
