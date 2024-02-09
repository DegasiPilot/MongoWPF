using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    internal class Axe : Weapon
    {
        public override string Name => "Axe";

        public override int Strength => 8 + RarityBonuses[Rarity];

        public override int Dexterity => 0;

        public override int Intelligence => 0;

        public override int Vitality => 0;

        public override int MaxHealth => 0;

        public override int MaxMana => 0;

        public override int PhysicalDamage => 8 + RarityBonuses[Rarity];

        public override int Armor => 0;

        public override int MagicDamage => 0;

        public override int MagicDefence => 0;

        public override int CritChanse => 20;

        public override int CritDamage => 170;

        public override bool IsShieldAvaliable => !IsTwoHanded;

        public override bool IsDualAvaliable => false;
    }
}
