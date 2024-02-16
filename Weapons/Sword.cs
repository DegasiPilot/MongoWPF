using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    internal class Sword : Weapon
    {
        public override string Name => "Sword";

        public override int Strength => 3;

        public override int Dexterity => 3;

        public override int Intelligence => Rarity > Rarity.Common ? 4 : 0;

        public override int Vitality => Rarity > Rarity.Common ? 4 : 0;

        public override int MaxHealth => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int MaxMana => Rarity > Rarity.Enchanted ? 4 : 0;

        public override int PhysicalDamage => 5;

        public override int CritChanse => 35;

        public override int CritDamage => 150;

        public override bool IsShieldAvaliable => !IsTwoHanded;

        public override bool IsDualAvaliable => false;
    }
}