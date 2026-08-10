namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sendAt;
        private bool _isRead;
        private DateTime _modifiedAt;

        public Message(Guid senderId, Guid receiverId, string content)
        {
            _id = Guid.NewGuid();
            _senderId = senderId;
            _receiverId = receiverId;
            _content = content;
            _sendAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public DateTime SendAt
        {
            get { return _sendAt; }
        }
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
