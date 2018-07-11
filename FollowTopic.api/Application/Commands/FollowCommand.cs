using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using MediatR;

namespace FollowTopic.api.Application.Commands
{
    [DataContract]
    public class FollowCommand:IRequest<bool>
    {
        [DataMember]
        public string TopicName { get; private set; }

        [DataMember]
        public string TopicContent { get; private set; }

        [DataMember]
        public string Owner { get; private set; }

        [DataMember]
        public DateTime CreatedDate { get; private set; }

        [DataMember]
        public List<string> Tag { get; private set; }

        [DataMember]
        public int Likes { get; private set; }

        [DataMember]
        public int Follower { get; private set; }

        [DataMember]
        public bool IsComplete { get; private set; }

        public FollowCommand(string topicName, string topicContent, string owner, DateTime createdDate, List<string> tag, int likes, int follower, bool isComplete)
        {   
            TopicName = topicName;
            TopicContent = topicContent;
            Owner = owner;
            CreatedDate = createdDate;
            Tag = tag;
            Likes = likes;
            Follower = follower;
            IsComplete = isComplete;
        }
    }
}
