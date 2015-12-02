namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int InjectionAttackEffect = 0;
        private const int InjectionHealthEffect = 200;
        private const int InjectionDefenseEffect = 0;

        public Injection(string id)
            : base(id, InjectionHealthEffect, InjectionDefenseEffect, InjectionAttackEffect)
        {
            this.Countdown = 3;
        }
    }
}