using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace FollowTopic.Infrastructure
{
    public class MongoDBConnection
    {
        private string _dbName;
        private string _connectionString;
        private MongoClient _client;

        public MongoDBConnection(string dbName, string connectionString)
        {
            _dbName = dbName;
            _connectionString = connectionString;
            _client = new MongoClient(_connectionString);
        }
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _client.GetDatabase(_dbName).GetCollection<T>(collectionName);
        }
    }
}
