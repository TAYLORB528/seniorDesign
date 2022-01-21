using System;
using MongoDB.Driver;
using Choosr.Models;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Choosr.Services
{
    public class UserPreferencesRestService
    {
        MongoClient mongoClient = new MongoClient("mongodb+srv://dbUser:Rainbows5@cluster0.aosjz.mongodb.net/test?authSource=admin&replicaSet=atlas-e43zyy-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");

        public UserPreferencesRestService()
        {
        }

        public async Task<BsonDocument> GetPreferences(string userId)
        {
            IMongoDatabase choosrDatabase = mongoClient.GetDatabase("choosr");
            var usersTable = choosrDatabase.GetCollection<BsonDocument>("users");
            var filter = Builders<BsonDocument>.Filter.Eq("UserId", userId);
            var users = usersTable.Find(filter).FirstOrDefault();
            return users;
        }
    }
}
