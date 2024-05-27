using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int ChanceOfFireBall = 50;
        private const int ChanceOfBarrier = 20;
        private const int HealEachNthRound = 2;
        private int attackCount;

        public Mage() : this("Gandalf")
        {
        
        }
        public Mage(string name) : base(name)
        {

        }
        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ChanceOfFireBall)) attack = attack * 3;

            attackCount = attack + 1;
            if (HealEachNthRound % attackCount == 0 && ThrowDice(20))
            {
                Heal(StartingHealth * 20 / 100);
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(ChanceOfBarrier)) incomingDamage = 0;

            base.TakeDamage(incomingDamage);
        }
    }
}
