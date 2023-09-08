using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class AlbumViewModel
    {
        public AlbumViewModel(Album album)
        {
            Title = album.Title;
            AuthorName = album.Author.Name;
            CreationDate = album.CreationDate;
            Tracks = album
                .Tracks
                .Select(t => new TrackForAlbumPageViewModel(t))
                .AsEnumerable();
            Comments = album
                .Comments
                .Select(c => new CommentViewModel(c))
                .AsEnumerable();
        }

        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreationDate { get; set; }
        public IEnumerable<TrackForAlbumPageViewModel> Tracks { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}
