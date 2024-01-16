using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Data.Dto;
using MoviesWebApi.Services;

namespace MoviesWebApi.Controllers
{    
    [Route("api/genres")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService genreService;

        public GenreController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        [HttpGet]

        public async Task<IActionResult> GetGenres()
        {
            IEnumerable<GenreDto> genres = await this.genreService.GetAllGenres();            
            return this.Ok(genres);
        }
    }
}
