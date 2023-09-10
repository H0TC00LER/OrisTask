using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class CardViewModel
    {
        public CardViewModel(Track track)
        {
            Title = track.Title;
            Subtitle = track.Author.Name;
            Id = track.Id;
        }

        public CardViewModel(Author author)
        {
            Title = author.Name;
            Id = author.Id;
        }

        public CardViewModel(Album album)
        {
            Title = album.Title;
            Subtitle = album.Author.Name;
            Id = album.Id;
        }

        public CardViewModel(RadioStation station)
        {
            Title = station.Name;
            Id = station.Id;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string? Subtitle { get; set; }
    }
}
