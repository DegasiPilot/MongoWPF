namespace MongoWPF.Equipment
{
    internal class PlateArmor : Equipment
    {
        public override string Name => "PlateArmor";

        public override int Armor => 10;
        public override int MaxHealth => 8;
        public override int Strength => 8;
        public override int Dexterity => -8;
        public override int PhysicalDamage => Rarity > Rarity.Common ? 5 : 0;
        public override int Vitality => Rarity > Rarity.Enchanted ? 8 : 0;

        public override int RequirementStrength => 40;
        public override int RequirementVitality => 30;
        public override int RequirementLevel => 15;
    }
}
