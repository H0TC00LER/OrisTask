namespace Domain.Entities
{
    public class Author
    {
        public string Id { get; set; }
        public string Name { get; set; }    
        public string ImageId { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Album> Albums { get; set; }
    }
}
