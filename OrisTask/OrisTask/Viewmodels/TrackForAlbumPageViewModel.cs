using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class TrackForAlbumPageViewModel
    {
        public TrackForAlbumPageViewModel(Track track)
        {
            Title = track.Title;
            AuthorName = track.Author.Name;
            DurationInSeconds = track.DurationInSeconds;
        }

        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int DurationInSeconds { get; set; }
        public string DurationInMinutes
            => TimeSpan.FromSeconds(DurationInSeconds).ToString(@"m\:ss");
    }
}
