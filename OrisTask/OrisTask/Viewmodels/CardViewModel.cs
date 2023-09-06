using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class CardViewModel
    {
        public CardViewModel(Track track)
        {
            Title = track.Title;
            Subtitle = track.Author.Name;
        }

        public CardViewModel(Author author)
        {
            Title = author.Name;
        }

        public CardViewModel(Album album)
        {
            Title = album.Title;
            Subtitle = album.Author.Name;
        }

        public string Title { get; set; }
        public string? Subtitle { get; set; }
        public string ImageId { get; set; }
    }
}
