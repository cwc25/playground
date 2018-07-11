using FollowTopic.Domain.AggregatesModel.TopicAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FollowTopic.Infrastructure
{
    public class TopicRepository : ITopicRepository
    {
        private MongoDBConnection _mongoDBConnection;

        public TopicRepository(MongoDBConnection mongoDBConnection)
        {
            _mongoDBConnection = mongoDBConnection;
        }
        public async Task<bool> FollowTopic(Topic topic)
        {
            await _mongoDBConnection.GetCollection<Topic>("followtopics").InsertOneAsync(topic);

            return true;
        }
    }
}
