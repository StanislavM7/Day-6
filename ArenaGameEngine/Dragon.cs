using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Dragon : Hero
    {
           public Dragon(string name) : base(name) 
        { 

        }
            public Dragon(string name) : base (name) 
        {
            firespellCount = 0;
        }
        private int firespellCount;

        public override int Attack()
        {
            firespellCount = firespellCount + 2;
            int baseAttack=base.Attack();
            if (firespellCount == 6)
            {
                baseAttack = baseAttack * 2;
                firespellCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(30, 71);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
