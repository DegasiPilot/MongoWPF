using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    internal class Fist : Weapon
    {
        public override string Name => "Кулак";

        public override int Strength => 0;

        public override int Dexterity => 0;

        public override int Intelligence => 0;

        public override int Vitality => 0;

        public override int MaxHealth => 0;

        public override int MaxMana => 0;

        public override int PhysicalDamage => 0;

        public override int Armor => 0;

        public override int MagicDamage => 0;

        public override int MagicDefence => 0;

        public override int CritChanse => 0;

        public override int CritDamage => 0;

        public override bool IsShieldAvaliable => true;

        public override bool IsDualAvaliable => false;
    }
}
