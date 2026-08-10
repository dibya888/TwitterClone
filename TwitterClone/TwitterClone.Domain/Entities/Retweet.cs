namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private string _content;
        private DateTime _retweetedAt;
        private DateTime _modifiedAt;

        public Retweet(Guid userId, Guid tweetId)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _tweetId = tweetId;
            _retweetedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

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
                if (value!=null && value.Length > 280)
                {
                    throw new ArgumentException("Tweet Cannot exceed 280 characters");
                }
                _content = value;
            }
        }

        public DateTime RetweetedAt
        {
            get { return _retweetedAt; }
        }

        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
