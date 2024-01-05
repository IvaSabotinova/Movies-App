using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;

namespace MoviesWebApi.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genresRepo;

        public GenreService(IRepository<Genre> genresRepo)
        {
            this.genresRepo = genresRepo;
        }
        public async Task<IEnumerable<SelectListItem>> GetAllGenres()
        {
            return await this.genresRepo.AllAsNoTracking()
                .Select(x => new SelectListItem
                {
                    Value = x.Id,
                    Text = x.Name,                     
                })
                .ToListAsync();
        }
    }
}
