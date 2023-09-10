using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrisTask.Viewmodels;
using Persistance;

namespace OrisTask.Pages.Home
{
    public class IndexModel : PageModel
    {
        public IEnumerable<CardViewModel> RecentlyPlayed;

        public IEnumerable<TrackSmallViewModel> WeeklyTop;

        public IEnumerable<CardViewModel> FeaturedArtsits;

        public IEnumerable<TrackSmallViewModel> NewReleases;

        public IEnumerable<CardViewModel> FeaturedAlbums;

        public IEnumerable<CardViewModel> LiveRadio;

        public GenreViewModel[] Genres;

        public AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var tracks = _context.Tracks.Include(t => t.Author);
            var authors = _context.Authors;
            var albums = _context.Albums.Include(a => a.Author).Include(a => a.Comments);
            var stations = _context.Stations;
            var genres = _context.Genres;

            RecentlyPlayed = tracks
                .Take(10)
                .Select(t => new CardViewModel(t))
                .AsEnumerable();

            WeeklyTop = tracks
                .OrderBy(t => t.Rating)
                .Take(10)
                .Select(t => new TrackSmallViewModel(t))
                .AsEnumerable();

            FeaturedArtsits = authors
                .Take(10)
                .Select(a => new CardViewModel(a))
                .AsEnumerable();

            NewReleases = tracks
                .Take(10)
                .Select(t => new TrackSmallViewModel(t))
                .AsEnumerable();

            FeaturedAlbums = albums
                .Take(10)
                .Select(a => new CardViewModel(a))
                .AsEnumerable();

            LiveRadio = stations
                .Take(10)
                .Select(r => new CardViewModel(r))
                .AsEnumerable();

            Genres = genres
                .Take(6)
                .Select(g => new GenreViewModel { Id = g.Id, Name = g.Name})
                .ToArray();
        }
    }
}
