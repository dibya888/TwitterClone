namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;

        public Tweet(Guid authorId)
        {
            _id = Guid.NewGuid();
            _authorId = authorId;
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
                if (value.Length > 280)
                {
                    throw new ArgumentException("Tweet Cannot exceed 280 characters");
                }
                _content = value; 
            }
        }
    }
}
