using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bard : Hero
    {
        private const int CriticalChance = 25;
        private const int DodgeChance = 20;

        public Bard() : this("Jimmy") 
        {
            
        }
        public Bard(string name) : base(name)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();
            Heal(attack / 3);
            if (ThrowDice(CriticalChance)) attack = attack * 2;
            return attack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(DodgeChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
