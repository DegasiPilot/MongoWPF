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

        public override int Strength => 8;

        public override int Dexterity => Rarity > Rarity.Common ? 4 : 0;

        public override int Intelligence => Rarity > Rarity.Common ? 4 : 0;

        public override int Vitality => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int MaxHealth => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int PhysicalDamage => 8;

        public override int CritChanse => 20;

        public override int CritDamage => 170;

        public override bool IsShieldAvaliable => !IsTwoHanded;

        public override bool IsDualAvaliable => false;
    }
}
