using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
        public int Strength => Weapon == null? BaseStrength : BaseStrength + Weapon.Strength;
        public int Dexterity => Weapon == null ? BaseDexterity : BaseDexterity + Weapon.Dexterity;
        public int Intelligence => Weapon == null ? BaseIntelligence : BaseIntelligence + Weapon.Intelligence;
        public int Vitality => Weapon == null ? BaseVitality : BaseVitality + Weapon.Vitality;
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
        public int MaxHealth => Weapon == null ? BaseMaxHealth : BaseMaxHealth + Weapon.MaxHealth;
        public int MaxMana => Weapon == null ? BaseMaxMana : BaseMaxMana + Weapon.MaxMana;
        public int PhysicalDamage => Weapon == null ? PhysicalDamage : PhysicalDamage + Weapon.PhysicalDamage;
        public int Armor => Weapon == null ? Armor : Armor + Weapon.Armor;
        public int MagicDamage => Weapon == null ? MagicDamage : MagicDamage + Weapon.MagicDamage;
        public int MagicDefence => Weapon == null ? MagicDefence : MagicDefence + Weapon.MagicDefence;
        public int CritChanse => Weapon == null ? CritChanse : CritChanse + Weapon.CritChanse;
        public int CritDamage => Weapon == null ? CritDamage : CritDamage + Weapon.CritDamage;
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
        }
    }
}
