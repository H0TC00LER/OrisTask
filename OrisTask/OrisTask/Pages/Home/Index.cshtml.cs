using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrisTask.Viewmodels;
using Persistance;

namespace OrisTask.Pages.Home
{
    public class IndexModel : PageModel
    {
        public List<CardViewModel> RecentlyPlayed;

        public List<TrackSmallViewModel> WeeklyTop;

        public List<CardViewModel> FeaturedArtsits;

        public List<TrackSmallViewModel> NewReleases;

        public List<CardViewModel> FeaturedAlbums;

        public List<CardViewModel> LiveRadio;

        public AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public async void OnGet()
        {
            var tracks = _context.Tracks.Include(t => t.Author);
            var authors = _context.Authors;
            var albums = _context.Albums.Include(a => a.Author).Include(a => a.Comments);

            RecentlyPlayed = await tracks
                .Take(10)
                .Select(t => new CardViewModel(t))
                .ToListAsync();

            WeeklyTop = await tracks
                .OrderBy(t => t.Rating)
                .Take(10)
                .Select(t => new TrackSmallViewModel(t))
                .ToListAsync();

            FeaturedArtsits = await authors
                .Take(10)
                .Select(a => new CardViewModel(a))
                .ToListAsync();

            NewReleases = await tracks
                .Take(10)
                .Select (t => new TrackSmallViewModel(t))
                .ToListAsync();

            FeaturedAlbums = await albums
                .Take(10)
                .Select(a => new CardViewModel(a))
                .ToListAsync();
        }
    }
}
