using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class TrackSmallViewModel
    {
        public TrackSmallViewModel(Track track)
        {
            Id = track.Id;
            TrackName = track.Title;
            AuthorName = track.Author.Name;
            DurationInSeconds = track.DurationInSeconds;
        }

        public string Id { get; set; }
        public string TrackName { get; set; }
        public string AuthorName { get; set; }
        public int DurationInSeconds { get; set; }
        public string DurationInMinutes
            => TimeSpan.FromSeconds(DurationInSeconds).ToString(@"m\:ss");
    }
}
