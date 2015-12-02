using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Caharcters
{
    public class Warrior : Character, IAttack
    {
        private int warriorAttackPoints = 150;
        private const int WarriorHealthPoints = 200;
        private const int WarriorDefensePoints = 100;
        private const int WarriorRange = 2;
        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, WarriorHealthPoints, WarriorDefensePoints, team, WarriorRange)
        {
        }
        public int AttackPoints
        {
            get { return this.warriorAttackPoints; }
            set { this.warriorAttackPoints = value; }
        }


        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var enemies = targetsList.Where(target => target.Team != this.Team && target.IsAlive);
            if (enemies.Count() > 0)
            {
                return enemies.First();
            }
            return targetsList.First(target => target.Team != Team);
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