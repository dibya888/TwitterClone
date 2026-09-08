namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikeable
    {
        private Guid _authorId;
        private string _content;


        public static string MaxContentLength => "280";

        public Tweet(Guid authorId, string content) : base(Guid.NewGuid())
        {
            _authorId = authorId;
            _content = content;
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

                if (value.Length > int.Parse(Tweet.MaxContentLength))
                {
                    throw new ArgumentException("Tweet content cannot exceed 280 characters");
                }
                _content = value; 
            }
        }

        public bool CanBeLiked()
        {
            return true;
        }
    }
}
