using System;
using System.Net.Http;
using System.Threading.Tasks;
using MongoDB.Driver;
using Choosr.Models;
using MongoDB.Bson;

namespace Choosr.Services
{
    public class UserRestService
    {
        MongoClient mongoClient = new MongoClient("mongodb+srv://dbUser:Rainbows5@cluster0.aosjz.mongodb.net/test?authSource=admin&replicaSet=atlas-e43zyy-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");

        public UserRestService()
        {
        }

        public async Task<User> GetUsers()
        {
            IMongoDatabase userTable = mongoClient.GetDatabase("users");
            var users = userTable.ListCollections();
            return (User)users;
        }

        public async Task<BsonDocument> GetUser(string userId)
        {
            IMongoDatabase choosrDatabase = mongoClient.GetDatabase("choosr");
            var usersTable = choosrDatabase.GetCollection<BsonDocument>("users");
            var filter = Builders<BsonDocument>.Filter.Eq("UserId", userId);
            var users = usersTable.Find(filter).FirstOrDefault();
            return users;
        }
    }
}
