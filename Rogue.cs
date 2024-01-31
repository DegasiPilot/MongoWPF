﻿using MongoDB.Bson;

namespace MongoWPF
{
    internal class Rogue : ICharacter
    {
        private ObjectId _id;

        public ObjectId Id { get => _id; set => _id = value; }
        public string Name { get; set; }

        public string ClassName => "Rogue";

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Vitality { get; set; }

        public int MinStrength => 20;
        public int MinDexterity => 30;
        public int MinInteligence => 15;
        public int MinVitality => 20;
        public int MaxStrength => 65;
        public int MaxDexterity => 250;
        public int MaxInteligence => 70;
        public int MaxVitality => 80;

        public int MaxHealth => Vitality + Vitality/2 + Strength/2;

        public int MaxMana => Inteligence + Inteligence/5;

        public int PhysicalDamage => Strength/2 + Dexterity/2;

        public int Armor => Dexterity + Dexterity/2;

        public int MagicDamage => Inteligence / 5;

        public int MagicDafence => Inteligence / 2;

        public int CritChanse => Dexterity / 5;

        public int CritDamage => Dexterity / 10;
    }
}
