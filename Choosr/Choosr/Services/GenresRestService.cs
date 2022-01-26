using System;
using MongoDB.Driver;
using Choosr.Models;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Choosr.Services
{
    public class GenresRestService
    {
        MongoClient mongoClient = new MongoClient("mongodb+srv://dbUser:Rainbows5@cluster0.aosjz.mongodb.net/test?authSource=admin&replicaSet=atlas-e43zyy-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");

        public GenresRestService()
        {
        }

        public async Task<IMongoCollection<BsonDocument>> GetGenres()
        {
            IMongoDatabase choosrDatabase = mongoClient.GetDatabase("choosr");
            var usersTable = choosrDatabase.GetCollection<BsonDocument>("genres");
            return usersTable;
        }
    }
}
