using MoviesWebApi.Data;

namespace MoviesWebApi.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAll();
    }
}
