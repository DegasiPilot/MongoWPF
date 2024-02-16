namespace MongoWPF.Equipments
{
    internal class LeatherArmor : Equipment
    {
        public override string Name => "LeatherArmor";

        public override int Armor => 5;
        public override int Dexterity => 8;
        public override int MaxHealth => 5;
        public override int Strength => 3;
        public override int CritChanse => Rarity > Rarity.Common ? 15 : 0;
        public override int CritDamage => Rarity > Rarity.Enchanted ? 25 : 0;

        public override int RequirementStrength => 35;
    }
}
