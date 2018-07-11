using FollowTopic.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace FollowTopic.Domain.AggregatesModel.TopicAggregate
{
    public class Topic: Entity
    {
        public string TopicName { get; private set; }
        public string TopicContent { get; private set; }
        public string Owner { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public List<string> Tag { get; private set; }
        public int Likes { get; private set; }
        public int Follower { get; private set; }
        public bool IsComplete { get; private set; }

        public Topic(string topicName, string topicContent, string owner, DateTime createdDate, List<string> tag, int likes, int follower, bool isComplete)
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

        public void UpdateLikes(int likes)
        {
            Likes += likes;
        }

        public void UpdateFollower(int follower)
        {
            Follower += follower;
        }

        public void UpdateCompletion(bool isComplete)
        {
            IsComplete = isComplete;
        }
    }
}
