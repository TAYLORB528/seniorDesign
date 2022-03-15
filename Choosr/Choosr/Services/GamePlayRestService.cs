using System;
using MongoDB.Driver;
using Choosr.Models;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Choosr.Services
{
    public class GamePlayRestService
    {
        MongoClient mongoClient = new MongoClient("mongodb+srv://dbUser:Rainbows5@cluster0.aosjz.mongodb.net/test?authSource=admin&replicaSet=atlas-e43zyy-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");

        public GamePlayRestService()
        {
        }

        public async void NewSession(GamePlay gameplay)
        {
            IMongoDatabase choosrDatabase = mongoClient.GetDatabase("choosr");
            IMongoCollection<BsonDocument> usersTable = choosrDatabase.GetCollection<BsonDocument>("gamePlay");
            var userId = ((App)App.Current).currUser.UserId;
            var document = new BsonDocument
            {
                { "user_id", userId },
                { "session_id", gameplay.SessionId },
                { "session_join_code", gameplay.JoinCode }
            };
            await usersTable.InsertOneAsync(document);
        }

        public async Task<BsonDocument> GetJoinCode(string JoinCode)
        {
            IMongoDatabase choosrDatabase = mongoClient.GetDatabase("choosr");
            var usersTable = choosrDatabase.GetCollection<BsonDocument>("gamePlay");
            var filter = Builders<BsonDocument>.Filter.Eq("session_join_code", JoinCode);
            var ID = usersTable.Find(filter).FirstOrDefault();
            return ID;
        }
    }
}