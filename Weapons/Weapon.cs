using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF.Weapons
{
    [BsonKnownTypes(typeof(Fist), typeof(Axe), typeof(Dagger), typeof(Hammer), typeof(Sword), typeof(Wand))]
    public abstract class Weapon : Item
    {
        public const float TwoHandledBonus = 1.7f;

        public bool IsTwoHanded;

        public abstract bool IsShieldAvaliable { get; }
        public abstract bool IsDualAvaliable { get; }
    }
}
