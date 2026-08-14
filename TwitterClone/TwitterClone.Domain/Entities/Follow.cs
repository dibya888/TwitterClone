namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followedAt;
        private DateTime _modifiedAt;

        public Follow(Guid followerId, Guid followingId)
        {
            _id = Guid.NewGuid();
            _followerId = followerId;
            _followingId = followingId;
            _followedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
        }

        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }

}
