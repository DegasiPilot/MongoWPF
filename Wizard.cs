﻿using MongoDB.Bson;
using System;

namespace MongoWPF
{
    internal class Wizard : ICharacter
    {
        private ObjectId _id;

        public ObjectId Id { get => _id; set => _id = value; }
        public string Name { get; set; }
        public string ClassName => "Wizard";
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

        public int MinStrength => 15;
        public int MinDexterity => 20;
        public int MinIntelligence => 35;
        public int MinVitality => 15;
        public int MaxStrength => 45;
        public int MaxDexterity => 80;
        public int MaxIntelligence => 250;
        public int MaxVitality => 70;

        public int MaxHealth => (int)Math.Ceiling(Vitality*1.4f) + Strength;

        public int MaxMana => Intelligence + Intelligence/2;

        public int PhysicalDamage => Strength/2;

        public int Armor => Dexterity;

        public int MagicDamage => Intelligence;

        public int MagicDefence => Intelligence;

        public int CritChanse => Dexterity / 5;

        public int CritDamage => Dexterity / 10;

        public Wizard()
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
