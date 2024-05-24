using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    internal class Wizard : Hero
    {
        public Wizard(string name) : base(name) 
        { 


        }

        public override void TakeDamage(int incomingDamage)
        {
            int fireballs = Random.Shared.Next(0, 100);
            if (fireballs <= 20)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack=base.Attack();
            int fireballs=Random.Shared.Next(0, 100);
            if(fireballs <= 20)
            {
                baseAttack = Strength * 2;
            }
            return baseAttack;
        }


    }
}
