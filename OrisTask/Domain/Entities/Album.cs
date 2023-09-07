namespace Domain.Entities
{
    public class Album
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public DateTime CreationDate { get; set; }
        public string? ImageId { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
