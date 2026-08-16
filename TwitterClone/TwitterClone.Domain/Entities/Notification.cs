namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        private Guid _userId;
        private string _type;
        private bool _isRead;

        public Notification(Guid userId, string type) : base(Guid.NewGuid())
        {
            _userId = userId;
            _type = type;
        }

        public Guid UserId
        {
            get { return _userId; }
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

        public string notificationInfo()
        {
            return $"UserId: {UserId}, Type: {Type}";
        }

        public abstract string GetMessage();
    }
}
