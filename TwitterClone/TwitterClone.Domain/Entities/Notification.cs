namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _userId;
        private string _message;
        private DateTime _createdAt;

        public Notification(Guid userId, string message)
        {
            _userId = userId;
            _message = message;
            _createdAt = DateTime.Now;
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
    }
}
