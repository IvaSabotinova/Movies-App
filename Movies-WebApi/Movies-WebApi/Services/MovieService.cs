using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;

namespace MoviesWebApi.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> moviesRepo;

        public MovieService(IRepository<Movie> moviesRepo)
        {
            this.moviesRepo = moviesRepo;
        }
        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await this.moviesRepo.AllAsNoTracking().ToListAsync();
        }
    }
}
