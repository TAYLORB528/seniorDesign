using System;
using MongoDB.Driver;
using Choosr.Models;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Choosr.Services
{
    public class SessionsRestService
    {
        MongoClient mongoClient = new MongoClient("mongodb+srv://dbUser:Rainbows5@cluster0.aosjz.mongodb.net/test?authSource=admin&replicaSet=atlas-e43zyy-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");

        public SessionsRestService()
        {
        }

        public async Task<IMongoCollection<BsonDocument>> GetSessionsHistory()
        {
            IMongoDatabase choosrDatabase = mongoClient.GetDatabase("choosr");
            var sessionsTable = choosrDatabase.GetCollection<BsonDocument>("sessions");
            //var filter = Builders<BsonDocument>.Filter.Eq("UserId", userId);
            //var users = usersTable.Find(filter).FirstOrDefault();
            return sessionsTable;
        }
    }
}
