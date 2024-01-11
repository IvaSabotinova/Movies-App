using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public interface IMovieService
    {
        Task<Movie> CreateMovie(MovieDto movieDto, string userId);

        Task<Movie> GetMovieById(string movieId);

        Task<MovieDetailsDto> GetMovieDetails(string movieId);

        Task<Movie> UpdateMovie(string movieId, MovieDto movieDto);

        Task DeleteMovie(string movieId);

        Task<MoviesListDto> GetAll(
            int page, 
            int itemsPerPage, 
            string? searchTerm = null, 
            string? genreIdFilter = null,
            string? sort = null);

    }
}
