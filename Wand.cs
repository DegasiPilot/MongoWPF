using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF
{
    internal class Wand : Weapon
    {
        public override int Strength => 0;

        public override int Dexterity => 0;

        public override int Intelligence => 5 + RarityBonuses[Rarity];

        public override int Vitality => 0;

        public override int MaxHealth => 0;

        public override int MaxMana => 5 + RarityBonuses[Rarity];

        public override int PhysicalDamage => 1 + RarityBonuses[Rarity];

        public override int Armor => 0;

        public override int MagicDamage => 5 + RarityBonuses[Rarity];

        public override int MagicDefence => 0;

        public override int CritChanse => 0;

        public override int CritDamage => 0;
    }
}
