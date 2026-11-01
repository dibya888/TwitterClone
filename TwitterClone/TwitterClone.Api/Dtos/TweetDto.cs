namespace TwitterClone.Api.Dtos
{
    public class TweetDto
    {
        public required Guid Id { get; set; }
        public required Guid AuthorId { get; set; }
        public required string Content { get; set; }
        public required DateTime CreatedAt { get; set; }
    }
}
