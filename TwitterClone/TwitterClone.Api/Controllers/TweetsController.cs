using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TweetsController : ControllerBase
    {
        public TweetsController()
        {
        }

        // POST: api/Tweets
        [HttpPost]
        public IActionResult CreateTweet()
        {
            return Ok(new
            {
                tweetId = Guid.NewGuid(),
                message = "Tweet created successfully!"
            });
        }

        // GET: api/Tweets/{tweetId}
        [HttpGet("{tweetId}")]
        public IActionResult GetTweetById(Guid tweetId)
        {
            return Ok(new
            {
                tweetId = tweetId,
                message = "Tweet details retrieved successfully!"
            });
        }

        // DELETE: api/Tweets/{tweetId}
        [HttpDelete("{tweetId}")]
        public IActionResult DeleteTweet(Guid tweetId)
        {
            return Ok(new
            {
                tweetId = tweetId,
                message = "Tweet deleted successfully!"
            });
        }

        // GET: api/Tweets
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<object>
            {
                new{ tweetId = Guid.NewGuid(), content = "This is a tweet." },
                new{ tweetId = Guid.NewGuid(), content = "This is another tweet." },
                new{ tweetId = Guid.NewGuid(), content = "Yet another tweet." }
            };
            return Ok(tweets);
        }


        // GET: api/Tweets/user/{userId}
        [HttpGet("user/{userId}")]
        public IActionResult GetTweetsByUserId(Guid userId)
        {
            var tweets = new List<object>
            {
                new{ tweetId = Guid.NewGuid(), userId = userId, content = "This is a tweet by the user." },
                new{ tweetId = Guid.NewGuid(), userId = userId, content = "This is another tweet by the user." }
            };
            return Ok(tweets);
        }


        // GET: api/Tweets/user/{userId}/date/{date}
        [HttpGet("user/{userId}/date/{date}")]
        public IActionResult GetTweetsByUserIdAndDate(Guid userId, DateTime date)
        {
            var tweets = new List<object>
            {
                new{ tweetId = Guid.NewGuid(), userId = userId, content = "This is a tweet by the user on the specified date.", date = date },
                new{ tweetId = Guid.NewGuid(), userId = userId, content = "This is another tweet by the user on the specified date.", date = date }
            };
            return Ok(tweets);
        }
    }
}
