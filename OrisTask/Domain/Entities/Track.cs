namespace Domain.Entities
{
    public class Track
    {
        public string Id { get; set; }  
        public string Title { get; set; }
        public Author Author { get; set; } 
        public string ImageId { get; set; } 
        public int DurationInSeconds { get; set; }
        public int Rating { get; set; }
    }
}
