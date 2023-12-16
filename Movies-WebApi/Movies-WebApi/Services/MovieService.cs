using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> moviesRepo;
        private readonly IRepository<Genre> genresRepo;

        public MovieService(
            IRepository<Movie> moviesRepo,
            IRepository<Genre> genresRepo)
        {
            this.moviesRepo = moviesRepo;
            this.genresRepo = genresRepo;
        }

        public async Task<IEnumerable<SelectListItem>> GetAllGenres()
        {
            return await this.genresRepo.AllAsNoTracking()
                .Select(x=> new SelectListItem
                {
                     Value = x.Id,
                     Text = x.Name,                      
                })
                .ToListAsync();
        }

        public async Task<Movie> CreateMovie(MovieCreateDto movieDto, string userId)
        {
            Movie newMovie = new Movie()
            {
                Title = movieDto.Title,
                GenreId = movieDto.GenreId,
                Description = movieDto.Description,
                Duration = movieDto.Duration,
                ReleaseDate = movieDto.ReleaseDate,
                ImageUrl = movieDto.ImageUrl,
                ApplicationUserId = userId,      
                
            };
            await this.moviesRepo.AddAsync(newMovie);
            await this.moviesRepo.SaveChangesAsync();

            return newMovie;
        }

        public async Task<Movie> GetMovieById(string id)
          => await this.moviesRepo.All().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await this.moviesRepo.AllAsNoTracking().ToListAsync();

        }     

    }
}
