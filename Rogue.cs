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

        public override int BaseMaxHealth => Vitality + Vitality / 2 + Strength / 2;
        public override int BaseMaxMana => Intelligence + Intelligence / 5;
        public override int BasePhysicalDamage => Strength / 2 + Dexterity / 2;
        public override int BaseArmor => Dexterity + Dexterity / 2;
        public override int BaseMagicDamage => Intelligence / 5;
        public override int BaseMagicDefence => Intelligence / 2;
        public override int BaseCritChanse => Dexterity / 5;
        public override int BaseCritDamage => Dexterity / 10;
    }
}
