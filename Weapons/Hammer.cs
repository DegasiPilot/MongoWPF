namespace MongoWPF.Weapons
{
    internal class Hammer : Weapon
    {
        public override string Name => "WarHammer";

        public override int Strength => 5;

        public override int Dexterity => Rarity > Rarity.Common ? 4 : 0;

        public override int Vitality => Rarity > Rarity.Common ? 4 : 0;

        public override int MaxHealth => 5;

        public override int MaxMana => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int PhysicalDamage => 8;

        public override int Armor => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int CritChanse => 10;

        public override int CritDamage => 250;

        public override bool IsShieldAvaliable => !IsTwoHanded;

        public override bool IsDualAvaliable => false;
    }
}