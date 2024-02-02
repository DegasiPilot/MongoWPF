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

        public override int MaxHealth => (int)Math.Ceiling(Vitality*1.4f) + Strength;
        public override int MaxMana => Intelligence + Intelligence/2;
        public override int PhysicalDamage => Strength/2;
        public override int Armor => Dexterity;
        public override int MagicDamage => Intelligence;
        public override int MagicDefence => Intelligence;
        public override int CritChanse => Dexterity / 5;
        public override int CritDamage => Dexterity / 10;
    }
}
