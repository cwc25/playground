using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FollowTopic.Domain.AggregatesModel.TopicAggregate
{
    public interface ITopicRepository
    {
        Task<bool> FollowTopic(Topic topic);
    }
}
