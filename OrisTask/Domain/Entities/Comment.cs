namespace Domain.Entities
{
    public class Comment
    {
        public string Id { get; set; } 
        public string CommentAuthor { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentText { get; set; }
        public string? ImageId { get; set; }
    }
}
