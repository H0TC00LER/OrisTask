using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrisTask.Viewmodels;
using Persistance;

namespace OrisTask.Pages
{
    public class AlbumModel : PageModel
    {
        private readonly AppDbContext _context;

        public AlbumViewModel Album;

        public IEnumerable<CardViewModel> YouMayAlsoLike;

        public IEnumerable<TrackSmallViewModel> NewReleases;

        public IEnumerable<CardViewModel> LiveRadio;

        public AlbumModel(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult OnGet(string id)
        {
            var album = _context
                .Albums
                .Include(a => a.Author)
                .Include(a => a.Tracks)
                .Include(a => a.Comments)
                .SingleOrDefault(a => a.Id == id);

            var tracks = _context.Tracks.Include(t => t.Author);
            var stations = _context.Stations;

            if (album == null)
                return NotFound();

            Album = new AlbumViewModel(album);

            YouMayAlsoLike = tracks
                .Take(10)
                .Select(t => new CardViewModel(t))
                .AsEnumerable();

            NewReleases = tracks
                .Take(10)
                .Select(t => new TrackSmallViewModel(t))
                .AsEnumerable();

            LiveRadio = stations
                .Take(10)
                .Select(r => new CardViewModel(r))
                .AsEnumerable();

            return Page();
        }
    }
}
