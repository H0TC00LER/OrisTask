namespace Domain.Entities
{
    public class Genre
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? ImageId { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
