using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        private string _message;
        public SystemNotification(Guid userId, string message) : base(userId, "System")
        {
            _message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, IsRead: {IsRead}, UserId: {UserId}";
        }

        public override string GetMessage()
        {
            return $"System Notification for User {UserId}: {_message}";
        }
    }
}
