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
        public override int Strength => Rarity > Rarity.Common ? 4 : 0;
        public override int Dexterity => 5;
        public override int Intelligence => Rarity > Rarity.Common ? 4 : 0;
        public override int Vitality => Rarity > Rarity.Enchanted ? 4 : 0;
        public override int MaxHealth => Rarity > Rarity.Enchanted ? 4 : 0;
        public override int PhysicalDamage => 3;
        public override int CritChanse => 60;
        public override int CritDamage => 70;
        public override bool IsShieldAvaliable => false;
        public override bool IsDualAvaliable => true;
    }
}