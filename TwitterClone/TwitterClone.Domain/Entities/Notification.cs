namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
        private Guid _userId;
        private string _message;
        private string _type;
        private bool _isRead;

        public Notification(Guid userId, string message, string type) : base(Guid.NewGuid())
        {
            _userId = userId;
            _message = message;
            _type = type;
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        protected string Message
        {
            get { return _message; }
            set { _message = value; }
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
    }
}
