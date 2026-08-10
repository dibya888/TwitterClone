namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _message;
        private DateTime _createdAt;
        private string _type;
        private bool _isRead;
        private DateTime _modifiedAt;

        public Notification(Guid userId, string message, string type)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _message = message;
            _createdAt = DateTime.UtcNow;
            _type = type;
        }

        public Guid Id
            {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public string Message
        {
            get { return _message; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
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
