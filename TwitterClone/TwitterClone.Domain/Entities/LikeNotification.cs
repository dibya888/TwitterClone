using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification(Guid likeByUserId, Guid tweetId) : base(likeByUserId, "Like")
        {
            TweetId = tweetId;
        }

        public Guid TweetId { get; private set; }


        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, IsRead: {IsRead}, LikedByUserId: {UserId}";
        }

        public override string GetMessage()
        {
            return $"User {UserId} liked your tweet: {TweetId}";
        }
    }
}
