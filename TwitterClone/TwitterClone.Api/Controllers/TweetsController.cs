using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Data;
using TwitterClone.Api.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{

    // api/tweets
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly TweetRepository _tweetRepository;

        public TweetsController(TweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;
        }


        // GET /api/tweets?userId={userId}
        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            var tweets = _tweetRepository.GetAllTweets()
                .Where(t => userId == null || t.AuthorId == userId)
                .Select(t => new TweetDto
                {
                    Id = t.Id,
                    AuthorId = t.AuthorId,
                    Content = t.Content,
                    CreatedAt = t.CreatedAt
                })
                .ToList();

            return Ok(tweets);
        }

        // GET /api/tweets/{id}
        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound(new { Message = "Tweet not found." });
            }

            return Ok(new TweetDto
            {
                Id = tweet.Id,
                AuthorId = tweet.AuthorId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            });
        }

        // POST /api/tweets
        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            var tweet = new Tweet(createTweetDto.AuthorId, createTweetDto.Content);
            _tweetRepository.AddTweet(tweet);

            return CreatedAtAction(nameof(GetTweetById), new { id = tweet.Id }, new TweetDto
            {
                Id = tweet.Id,
                AuthorId = tweet.AuthorId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            });
        }

        // PUT /api/tweets/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute] Guid id, [FromBody] UpdateTweetDto updateTweetDto)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound(new { Message = "Tweet not found." });
            }

            tweet.Content = updateTweetDto.Content;
            _tweetRepository.UpdateTweet(tweet);

            return Ok(new TweetDto
            {
                Id = tweet.Id,
                AuthorId = tweet.AuthorId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            });
        }

        // DELETE /api/tweets/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound(new { Message = "Tweet not found." });
            }

            return Ok(new
            {
                TweetId = id,
                Message = "Tweet deleted successfully.",
            });
        }
    }
}