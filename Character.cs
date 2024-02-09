using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoWPF.Weapons;

namespace MongoWPF
{
    [BsonKnownTypes(typeof(Warrior), typeof(Rogue), typeof(Wizard))]
    public abstract class Character
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public abstract string ClassName { get; }
        private int expirience;
        public int Expirience
        {
            get => expirience;
            set
            {
                expirience = value;
                OnExpUpdate();
            }
        }
        private int level;
        public int Level
        {
            get => level;
            set
            {
                UnSpentedStatPoints += (value - level) * 5;
                level = value;
            }
        }

        public int UnSpentedStatPoints { get; set; }
        public int Strength => BaseStrength + Weapon.Strength;
        public int Dexterity => BaseDexterity + Weapon.Dexterity;
        public int Intelligence => BaseIntelligence + Weapon.Intelligence;
        public int Vitality => BaseVitality + Weapon.Vitality;
        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseIntelligence { get; set; }
        public int BaseVitality { get; set; }
        public abstract int MinStrength { get; }
        public abstract int MinDexterity { get; }
        public abstract int MinIntelligence { get; }
        public abstract int MinVitality { get; }
        public abstract int MaxStrength { get; }
        public abstract int MaxDexterity { get; }
        public abstract int MaxIntelligence { get; }
        public abstract int MaxVitality { get; }
        public int MaxHealth => BaseMaxHealth + Weapon.MaxHealth;
        public int MaxMana => BaseMaxMana + Weapon.MaxMana;
        public int PhysicalDamage => BasePhysicalDamage + Weapon.PhysicalDamage;
        public int Armor => BaseArmor + Weapon.Armor;
        public int MagicDamage => BaseMagicDamage + Weapon.MagicDamage;
        public int MagicDefence => BaseMagicDefence + Weapon.MagicDefence;
        public int CritChanse => BaseCritChanse + Weapon.CritChanse;
        public int CritDamage => BaseCritDamage + Weapon.CritDamage;
        public abstract int BaseMaxHealth { get; }
        public abstract int BaseMaxMana { get; }
        public abstract int BasePhysicalDamage { get; }
        public abstract int BaseArmor { get; }
        public abstract int BaseMagicDamage { get; }
        public abstract int BaseMagicDefence { get; }
        public abstract int BaseCritChanse { get; }
        public abstract int BaseCritDamage { get; }

        public Weapon Weapon { get; set; }

        public void OnExpUpdate()
        {
            while (Expirience >= this.TotalExpForNextLvl())
            {
                Level++;
            }
        }

        public Character()
        {
            BaseStrength = MinStrength;
            BaseDexterity = MinDexterity;
            BaseIntelligence = MinIntelligence;
            BaseVitality = MinVitality;
            Level = 1;
            Name = "";
            Weapon = new Fist();
        }
    }
}