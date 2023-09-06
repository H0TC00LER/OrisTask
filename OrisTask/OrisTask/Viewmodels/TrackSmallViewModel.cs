using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class TrackSmallViewModel
    {
        public TrackSmallViewModel(Track track)
        {
            TrackName = track.Title;
            AuthorName = track.Author.Name;
            DurationInSeconds = track.DurationInSeconds;
        }

        public string TrackName { get; set; }
        public string AuthorName { get; set; }
        public int DurationInSeconds { get; set; }
        public string DurationInMinutes => $"{DurationInSeconds / 60}:{DurationInSeconds % 60}";
        public string ImageId { get; set; }
    }
}
