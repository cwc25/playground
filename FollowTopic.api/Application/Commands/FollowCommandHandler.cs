using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FollowTopic.Domain.AggregatesModel.TopicAggregate;
using MediatR;

namespace FollowTopic.api.Application.Commands
{
    public class FollowCommandHandler : IRequestHandler<FollowCommand, bool>
    {
        private readonly ITopicRepository _topicRepository;

        public FollowCommandHandler(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }
        public async Task<bool> Handle(FollowCommand request, CancellationToken cancellationToken)
        {
            var topic = new Topic(request.TopicName, 
                                  request.TopicContent, 
                                  request.Owner, 
                                  request.CreatedDate, 
                                  request.Tag, 
                                  request.Likes, 
                                  request.Follower, 
                                  request.IsComplete);

             return await _topicRepository.FollowTopic(topic);

        }
    }
}
