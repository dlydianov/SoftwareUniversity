namespace TheSlum.Items
{
    public class Axe : Item
    {
        private const int HealthEffect = 0;
        private const int DefenceEffect = 0;
        private const int AttackEffect = 75;
        public Axe(string id)
            : base(id, HealthEffect, DefenceEffect, AttackEffect)
        {
        }
    }
}