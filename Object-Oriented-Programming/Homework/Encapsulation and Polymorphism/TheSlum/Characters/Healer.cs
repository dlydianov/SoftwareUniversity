using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Caharcters
{
    public class Healer :Character, IHeal
    {
        private int healerHealingPoints = 60;
        private const int healerHealthPoints = 75;
        private const int healerDefencePoints = 50;
        private const int healerRange = 6;


        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, healerHealthPoints, healerDefencePoints, team, healerRange)
        {
        }

        public int HealingPoints
        {
            get { return this.healerHealingPoints; }
            set { this.healerHealingPoints = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .Where(target => target.Team == this.Team && target.IsAlive && target.Id != this.Id)
                .OrderBy(target => target.HealthPoints)
                .First();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Healing: {0}", HealingPoints);
        }
    }
}