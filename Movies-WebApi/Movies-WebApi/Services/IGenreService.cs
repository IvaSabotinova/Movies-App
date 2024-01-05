using Microsoft.AspNetCore.Mvc.Rendering;

namespace MoviesWebApi.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<SelectListItem>> GetAllGenres();
    }
}
