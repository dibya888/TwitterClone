using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Data
{
    public class TweetRepository
    {
        private List<Tweet> _tweets { get; set; } = new List<Tweet>();

        public Tweet AddTweet(Tweet tweet)
        {
            _tweets.Add(tweet);
            return tweet;
        }

        public Tweet UpdateTweet(Tweet tweet)
        {
            _tweets.RemoveAll(t => t.Id == tweet.Id);
            _tweets.Add(tweet);
            return tweet;
        }
        
        public bool DeleteTweet(Tweet tweet)
        {
            return _tweets.Remove(tweet);
        }

        public Tweet? GetTweetById(Guid id)
        {
            return _tweets.SingleOrDefault(t => t.Id == id); //Cause an exception if more than one tweet with the same id exists
        }

        public List<Tweet> GetAllTweets()
        {
            return _tweets;
        }

    }
}
