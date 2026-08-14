namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private bool _isRead;

        public Message(Guid senderId, Guid receiverId, string content) : base(Guid.NewGuid())
        {
            _senderId = senderId;
            _receiverId = receiverId;
            _content = content;
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

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }
    }
}
