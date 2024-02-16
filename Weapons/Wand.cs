using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    internal class Wand : Weapon
    {
        public override string Name => "Wand";

        public override int Strength => Rarity > Rarity.Common ? 4 : 0;

        public override int Dexterity => Rarity > Rarity.Common ? 4 : 0;

        public override int Intelligence => 5;

        public override int Vitality => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int MaxHealth => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int MaxMana => 5;

        public override int PhysicalDamage => 1;

        public override int MagicDamage => 5;

        public override bool IsShieldAvaliable => false;

        public override bool IsDualAvaliable => false;
    }
}