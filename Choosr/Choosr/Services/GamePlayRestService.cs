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
            var document = new BsonDocument
            {
                {"user_id", gameplay.UserId},
                { "session_id", gameplay.SessionId},
                { "session_join_code", gameplay.JoinCode}
            };
            await usersTable.InsertOneAsync(document);
         }
    }
}
