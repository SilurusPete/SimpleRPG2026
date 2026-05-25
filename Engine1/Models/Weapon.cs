namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int Damage { get; set; }
        public int CriticalHitDamage { get; set; }

        public Weapon(int itemTypeID, string name, int price, int damage, int criticalHitDamage)
            : base(itemTypeID, name, price, true)
        {
            Damage = damage;
            CriticalHitDamage = criticalHitDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, Damage, CriticalHitDamage);
        }
    }
}
