namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;

        public Like(Guid userId, Guid tweetId)
        {
            _userId = userId;
            _tweetId = tweetId;
            _likedAt = DateTime.Now;
        }

        public Guid UserId
        {
            get { return _userId; }
        }
        public Guid TweerId
        {
            get { return _tweetId; }
        }

        public DateTime LikedAt
        {
            get { return DateTime.Now; }
        }
    }
}
