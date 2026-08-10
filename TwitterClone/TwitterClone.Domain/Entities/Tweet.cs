namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Tweet(Guid authorId)
        {
            _id = Guid.NewGuid();
            _authorId = authorId;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tweet content cannot be empty");
                }

                if (value.Length > 280)
                {
                    throw new ArgumentException("Tweet content cannot exceed 280 characters");
                }
                _content = value; 
            }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
