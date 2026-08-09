namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _content;
        private DateTime _retweetedAt;

        public Retweet(Guid userId, Guid tweetId)
        {
            _userId = userId;
            _tweetId = tweetId;
            _retweetedAt = DateTime.Now;
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
                if (value.Length > 280)
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
    }
}
