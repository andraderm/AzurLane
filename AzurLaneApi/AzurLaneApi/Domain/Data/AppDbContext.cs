using AzurLaneApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AzurLaneApi.Domain.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "AzurLaneDb";
        private const string ShipCollectionName = "Ship";
        private const string FleetCollectionName = "Fleet";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;
        
        public IMongoClient Client => _client;
        public new IMongoDatabase Database => _database;

        static AppDbContext()
        {
            _client = new MongoClient(ConnectionString);
            _database = _client.GetDatabase(DatabaseName);
        }

        public IMongoCollection<Ship> Ships => _database.GetCollection<Ship>(ShipCollectionName);
        public IMongoCollection<Fleet> Fleets => _database.GetCollection<Fleet>(FleetCollectionName);
    }
}
