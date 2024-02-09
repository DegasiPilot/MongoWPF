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

        public override int Intelligence => 0;

        public override int Vitality => 0;

        public override int MaxHealth => 0;

        public override int MaxMana => 0;

        public override int PhysicalDamage => 5;

        public override int Armor => 0;

        public override int MagicDamage => 0;

        public override int MagicDefence => 0;

        public override int CritChanse => 35;

        public override int CritDamage => 150;
    }
}
