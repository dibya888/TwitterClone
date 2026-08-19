using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base(mentionedByUserId, "Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }

        public Guid MentionedByUserId { get; private set; }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, IsRead: {IsRead}, MentionedByUserId: {MentionedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User {MentionedByUserId} mentioned you in a tweet.";
        }

    }
}
