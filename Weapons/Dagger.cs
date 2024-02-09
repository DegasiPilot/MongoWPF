using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    internal class Dagger : Weapon
    {
        public override string Name => "Dagger";

        public override int Strength => 0;

        public override int Dexterity => 5 + RarityBonuses[Rarity];

        public override int Intelligence => 0;

        public override int Vitality => 0;

        public override int MaxHealth => 0;

        public override int MaxMana => 0;

        public override int PhysicalDamage => 3 + RarityBonuses[Rarity];

        public override int Armor => 0;

        public override int MagicDamage => 0;

        public override int MagicDefence => 0;

        public override int CritChanse => 60;

        public override int CritDamage => 70;
    }
}
