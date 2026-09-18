using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TwitterController(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetTweets()
        {
            string? maxLength = _configuration["TwitterSettings:MaxTweetLength"];
            string? appName = _configuration["AppName"];

            var tweets = new List<Tweet>
            {
                new Tweet(Guid.NewGuid(), "My First Tweet")
                {
                    Content = "Hello, world!",
                },
                new Tweet(Guid.NewGuid(), "My Second Tweet")
                {
                    Content = "My second Tweet",
                }
            };

            return Ok(new Dictionary<string, object>
            {
                { "appName", appName },
                { "maxLength", maxLength },
                { "tweets", tweets }
            });
        }
    }
}
