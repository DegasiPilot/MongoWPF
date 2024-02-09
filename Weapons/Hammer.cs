using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    internal class Hammer : Weapon
    {
        public override string Name => "WarHammer";

        public override int Strength => 5 + RarityBonuses[Rarity];

        public override int Dexterity => 0;

        public override int Intelligence => 0;

        public override int Vitality => 0;

        public override int MaxHealth => 5 + RarityBonuses[Rarity];

        public override int MaxMana => 0;

        public override int PhysicalDamage => 8 + RarityBonuses[Rarity];

        public override int Armor => 0;

        public override int MagicDamage => 0;

        public override int MagicDefence => 0;

        public override int CritChanse => 10;

        public override int CritDamage => 250;

        public override bool IsShieldAvaliable => !IsTwoHanded;

        public override bool IsDualAvaliable => false;
    }
}
