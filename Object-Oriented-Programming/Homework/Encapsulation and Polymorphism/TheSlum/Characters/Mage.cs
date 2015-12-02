using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Caharcters
{
    public class Mage : Character, IAttack
    {
        private int mageAttackPoints = 300;
        private const int mageHealthPoints = 150;
        private const int mageDefensePoints = 50;
        private const int mageRange = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, mageHealthPoints, mageDefensePoints, team, mageRange)
        {
        }

        public int AttackPoints
        {
            get { return this.mageAttackPoints; }
            set { this.mageAttackPoints = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var enemies = targetsList.Where(target => target.Team != this.Team && target.IsAlive);
            if (enemies.Count() < 0)
            {
                return enemies.Last();
            }
            return targetsList.Last(target => target.Team != this.Team);
        }
        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(", Attack: {0}", this.AttackPoints);
        }

    }
}