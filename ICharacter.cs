using MongoDB.Bson;
using System.ComponentModel;

namespace MongoWPF
{
    public interface ICharacter
    {
        ObjectId Id { get; set; }
        string Name { get; set; }
        string ClassName { get;}
        int Expirience { get; set; }
        int Level { get;}

        int Strength { get; set; }
        int Dexterity { get; set; }
        int Intelligence { get; set; }
        int Vitality { get; set; }

        int MinStrength { get; }
        int MinDexterity { get; }
        int MinIntelligence { get; }
        int MinVitality { get; }
        int MaxStrength { get; }
        int MaxDexterity { get; }
        int MaxIntelligence { get; }
        int MaxVitality { get; }

        int MaxHealth { get; }
        int MaxMana { get; }
        int PhysicalDamage { get; }
        int Armor { get; }
        int MagicDamage { get; }
        int MagicDefence { get; }
        int CritChanse { get; }
        int CritDamage { get; }
    }
}