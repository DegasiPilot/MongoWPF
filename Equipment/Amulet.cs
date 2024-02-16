namespace MongoWPF.Equipment
{
    internal class Amulet : Equipment
    {
        public override string Name => "Amulet";

        public override int Intelligence => 5;
        public override int MagicDamage => 10;
        public override int MaxMana => 15;
    }
}
