using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF
{
    internal class CRUD
    {
        public static void CreateCharacter(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDb");
            var collection = database.GetCollection<Character>("Characters");
            collection.InsertOne(character);
        }

        public static void RedactCharacter(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDb");
            var collection = database.GetCollection<Character>("Characters");
            Character redactableCharacter = collection.Find(x => x.Id == character.Id).First();
            redactableCharacter = character;
        }

        public static Character GetCharacter(ObjectId Id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDb");
            var collection = database.GetCollection<Character>("Characters");
            var character = collection.Find(x => x.Id == Id).FirstOrDefault();

            return character;
        }

        public static bool IsExistCharacterName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDb");
            var collection = database.GetCollection<Character>("Characters");
            return collection.Find(x => x.Name == name).CountDocuments() > 0;
        }
    }
}