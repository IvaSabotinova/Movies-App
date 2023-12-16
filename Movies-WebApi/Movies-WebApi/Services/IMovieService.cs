using MoviesWebApi.Data.Dto;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MoviesWebApi.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<SelectListItem>> GetAllGenres();

        Task<Movie> CreateMovie(MovieCreateDto movieDto, string userId);

        Task<Movie> GetMovieById(string id);

        Task<IEnumerable<Movie>> GetAll();


    }
}
