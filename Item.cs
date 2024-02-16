using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF
{
    public abstract class Item
    {
        public abstract string Name { get; }
        public Rarity Rarity = Rarity.Common;

        public virtual int Strength => 0;
        public virtual int Dexterity => 0;
        public virtual int Intelligence => 0;
        public virtual int Vitality => 0;
        public virtual int MaxHealth => 0;
        public virtual int MaxMana => 0;
        public virtual int PhysicalDamage => 0;
        public virtual int Armor => 0;
        public virtual int MagicDamage => 0;
        public virtual int MagicDefence => 0;
        public virtual int CritChanse => 0;
        public virtual int CritDamage => 0;
    }
}
