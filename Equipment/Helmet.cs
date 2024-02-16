namespace MongoWPF.Equipment
{
    internal class Helmet : Equipment
    {
        public override string Name => "Helmet";
        public int level = 1;

        public override int Armor => 3 * level;
        public override int MaxHealth => 2 * level;

        public override int RequirementStrength => 15 * level;
    }
}
