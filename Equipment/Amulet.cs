namespace MongoWPF.Equipment
{
    internal class Amulet : Equipment
    {
        public override string Name => "Amulet";
        public int RareBonus => Rarity == Rarity.Rare ? 4 : 0;

        public override int Intelligence => 5 + RareBonus;
        public override int MagicDamage => 10 + RareBonus;
        public override int MaxMana => 15 + RareBonus;

        public override int Strength => RareBonus;
        public override int Dexterity => RareBonus;
        public override int Vitality => RareBonus;
        public override int MaxHealth => RareBonus;
        public override int PhysicalDamage => RareBonus;
        public override int Armor => RareBonus;
        public override int MagicDefence => RareBonus;
        public override int CritChanse => RareBonus;
        public override int CritDamage => RareBonus;
    }
}
