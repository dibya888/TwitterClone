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
    }
}
