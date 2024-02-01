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
        public static void CreateCharacter(ICharacter character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDB");
            var collection = database.GetCollection<ICharacter>("Characters");
            collection.InsertOne(character);
        }

        public static ICharacter GetCharacter(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TimurDB");
            var collection = database.GetCollection<ICharacter>("ICharacters");
            var character = collection.Find(x => x.Name == name).FirstOrDefault();

            return character;
        }
    }
}
