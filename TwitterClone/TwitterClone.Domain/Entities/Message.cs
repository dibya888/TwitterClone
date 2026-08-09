namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sendAt;

        public Message(Guid senderId, Guid receiverId, string content)
        {
            _senderId = senderId;
            _receiverId = receiverId;
            _content = content;
            _sendAt = DateTime.Now;
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
    }
}
