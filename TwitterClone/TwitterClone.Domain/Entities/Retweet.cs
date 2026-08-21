namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _content;

        public Retweet(Guid userId, Guid tweetId) : base(Guid.NewGuid())
        {
            _userId = userId;
            _tweetId = tweetId;
        }

        public static string MaxContentLength => "280";

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                if (value!=null && value.Length > int.Parse(Retweet.MaxContentLength))
                {
                    throw new ArgumentException("Retweet content cannot exceed 280 characters");
                }
                _content = value;
            }
        }
    }
}
