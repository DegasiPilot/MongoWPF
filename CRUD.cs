using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoWPF
{
    internal class CRUD
    {
        public static void CreateCharacter(Character character)
        {
            var collection = GetCharactersCollection();
            collection.InsertOne(character);
        }

        public static void RedactCharacter(Character character)
        {
            var collection = GetCharactersCollection();
            collection.ReplaceOne(x => x.Id == character.Id, character);
        }

        public static Character GetCharacter(ObjectId Id)
        {
            var collection = GetCharactersCollection();
            return collection.Find(x => x.Id == Id).FirstOrDefault();
        }

        public static Character GetCharacter(string name)
        {
            var collection = GetCharactersCollection();
            return collection.Find(x => x.Name == name).FirstOrDefault();
        }

        public static bool IsExistCharacterName(string name)
        {
            var collection = GetCharactersCollection();
            return collection.Find(x => x.Name == name).CountDocuments() > 0;
        }

        public static bool TryDeleteCharacter(ObjectId id)
        {
            var collection = GetCharactersCollection();
            return collection.DeleteOne(x => x.Id == id).DeletedCount > 0;
        }

        private static IMongoCollection<Character> GetCharactersCollection()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDb");
            return database.GetCollection<Character>("Characters");
        }
    }
}