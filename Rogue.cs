using MongoDB.Bson;
using System.ComponentModel;

namespace MongoWPF
{
    internal class Rogue : ICharacter
    {
        private ObjectId _id;

        public ObjectId Id { get => _id; set => _id = value; }
        public string Name { get; set; }
        public string ClassName => "Rogue";
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

        public int MinStrength => 20;
        public int MinDexterity => 30;
        public int MinIntelligence => 15;
        public int MinVitality => 20;
        public int MaxStrength => 65;
        public int MaxDexterity => 250;
        public int MaxIntelligence => 70;
        public int MaxVitality => 80;

        public int MaxHealth => Vitality + Vitality / 2 + Strength / 2;

        public int MaxMana => Intelligence + Intelligence / 5;

        public int PhysicalDamage => Strength / 2 + Dexterity / 2;

        public int Armor => Dexterity + Dexterity / 2;

        public int MagicDamage => Intelligence / 5;

        public int MagicDefence => Intelligence / 2;

        public int CritChanse => Dexterity / 5;

        public int CritDamage => Dexterity / 10;

        public Rogue()
        {
            Strength = MinStrength;
            Dexterity = MinDexterity;
            Intelligence = MinIntelligence;
            Vitality = MinVitality;
            Level = 1;
        }

        public void OnExpUpdate()
        {
            while (Expirience >= this.TotalExpForNextLvl())
            {
                Level++;
            }
        }
    }
}
