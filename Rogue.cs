using MongoDB.Bson;
using System.ComponentModel;

namespace MongoWPF
{
    internal class Rogue : Character
    {
        public override string ClassName => "Rogue";

        public override int MinStrength => 20;
        public override int MinDexterity => 30;
        public override int MinIntelligence => 15;
        public override int MinVitality => 20;
        public override int MaxStrength => 65;
        public override int MaxDexterity => 250;
        public override int MaxIntelligence => 70;
        public override int MaxVitality => 80;

        public override int MaxHealth => Vitality + Vitality / 2 + Strength / 2;
        public override int MaxMana => Intelligence + Intelligence / 5;
        public override int PhysicalDamage => Strength / 2 + Dexterity / 2;
        public override int Armor => Dexterity + Dexterity / 2;
        public override int MagicDamage => Intelligence / 5;
        public override int MagicDefence => Intelligence / 2;
        public override int CritChanse => Dexterity / 5;
        public override int CritDamage => Dexterity / 10;
    }
}
