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
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public abstract int MinStrength { get; }
        public abstract int MinDexterity { get; }
        public abstract int MinIntelligence { get; }
        public abstract int MinVitality { get; }
        public abstract int MaxStrength { get; }
        public abstract int MaxDexterity { get; }
        public abstract int MaxIntelligence { get; }
        public abstract int MaxVitality { get; }
        public abstract int MaxHealth { get; }
        public abstract int MaxMana { get; }
        public abstract int PhysicalDamage { get; }
        public abstract int Armor { get; }
        public abstract int MagicDamage { get; }
        public abstract int MagicDefence { get; }
        public abstract int CritChanse { get; }
        public abstract int CritDamage { get; }

        public void OnExpUpdate()
        {
            while (Expirience >= this.TotalExpForNextLvl())
            {
                Level++;
            }
        }

        public Character()
        {
            Strength = MinStrength;
            Dexterity = MinDexterity;
            Intelligence = MinIntelligence;
            Vitality = MinVitality;
            Level = 1;
            Name = "";
        }
    }
}
