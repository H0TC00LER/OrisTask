namespace Domain.Entities
{
    public class Track
    {
        public string Id { get; set; }  
        public string Title { get; set; }
        public Album? Album { get; set; }
        public Author Author { get; set; }
        public int DurationInSeconds { get; set; }
        public int Rating { get; set; }
    }
}
