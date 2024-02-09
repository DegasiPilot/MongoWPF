using MongoDB.Bson;
using System;

namespace MongoWPF
{
    internal class Wizard : Character
    {
        public override string ClassName => "Wizard";

        public override int MinStrength => 15;
        public override int MinDexterity => 20;
        public override int MinIntelligence => 35;
        public override int MinVitality => 15;
        public override int MaxStrength => 45;
        public override int MaxDexterity => 80;
        public override int MaxIntelligence => 250;
        public override int MaxVitality => 70;

        public override int BaseMaxHealth => (int)Math.Ceiling(Vitality*1.4f) + Strength;
        public override int BaseMaxMana => Intelligence + Intelligence/2;
        public override int BasePhysicalDamage => Strength/2;
        public override int BaseArmor => Dexterity;
        public override int BaseMagicDamage => Intelligence;
        public override int BaseMagicDefence => Intelligence;
        public override int BaseCritChanse => Dexterity / 5;
        public override int BaseCritDamage => Dexterity / 10;
    }
}
