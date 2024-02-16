namespace MongoWPF.Equipment
{
    internal class ChainArmor : Equipment
    {
        public override string Name => "ChainArmor";

        public override int Armor => 8;
        public override int MaxHealth => 5;
        public override int Strength => 5;
        public override int Dexterity => -3;
        public override int PhysicalDamage => Rarity > Rarity.Common ? 3 : 0;
        public override int Vitality => Rarity > Rarity.Enchanted ? 5 : 0;

        public override int RequirementStrength => 35;
        public override int RequirementLevel => 10;
    }
}
