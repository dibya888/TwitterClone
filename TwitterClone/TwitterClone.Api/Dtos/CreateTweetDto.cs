namespace TwitterClone.Api.Dtos
{
    public class CreateTweetDto
    {
        public required Guid AuthorId { get; set; }
        public required string Content { get; set; }
    }
}
