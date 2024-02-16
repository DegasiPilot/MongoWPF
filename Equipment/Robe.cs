namespace MongoWPF.Equipment
{
    internal class Robe : Equipment
    {
        public override string Name => "Robe";

        public override int Armor => 3;
        public override int MaxMana => 8;
        public override int Intelligence => 8;
        public override int MaxHealth => 3;
        public override int MagicDamage => Rarity > Rarity.Common ? 4 : 0;
        public override int MagicDefence => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int RequirementStrength => 30;
        public override int RequirementVitality => 25;
    }
}