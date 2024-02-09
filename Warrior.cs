using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF
{
    internal class Warrior : Character
    {
        public override string ClassName => "Warrior";

        public override int MinStrength => 30;
        public override int MinDexterity => 15;
        public override int MinIntelligence => 10;
        public override int MinVitality => 25;
        public override int MaxStrength => 250;
        public override int MaxDexterity => 80;
        public override int MaxIntelligence => 50;
        public override int MaxVitality => 100;

        public override int BaseMaxHealth => 2*Vitality + Strength;
        public override int BaseMaxMana => Intelligence;
        public override int BasePhysicalDamage => Strength;
        public override int BaseArmor => Dexterity;
        public override int BaseMagicDamage => Intelligence / 5;
        public override int BaseMagicDefence => Intelligence / 2;
        public override int BaseCritChanse => Dexterity / 5;
        public override int BaseCritDamage => Dexterity / 10;
    }
}
