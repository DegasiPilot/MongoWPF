using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    [BsonKnownTypes(typeof(Fist), typeof(Axe), typeof(Dagger), typeof(Hammer), typeof(Sword), typeof(Wand))]
    public abstract class Weapon
    {
        public static Dictionary<WeaponRarity, int> RarityBonuses = new Dictionary<WeaponRarity, int>()
        {
            {WeaponRarity.Common , 0 },
            {WeaponRarity.Enchanted, 2 },
            {WeaponRarity.Rare, 4 }
        };

        public abstract string Name { get; }
        public WeaponRarity Rarity;
        public bool IsTwoHanded;

        public abstract int Strength { get; }
        public abstract int Dexterity { get; }
        public abstract int Intelligence { get; }
        public abstract int Vitality { get; }

        public abstract int MaxHealth { get; }
        public abstract int MaxMana { get; }
        public abstract int PhysicalDamage { get; }
        public abstract int Armor { get; }
        public abstract int MagicDamage { get; }
        public abstract int MagicDefence { get; }
        public abstract int CritChanse { get; }
        public abstract int CritDamage { get; }
    }
}
