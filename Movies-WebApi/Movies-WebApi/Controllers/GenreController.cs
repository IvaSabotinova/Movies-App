using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesWebApi.Services;

namespace Movies_WebApi.Controllers
{
    //[Route("api/[controller]")]
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
            IEnumerable<SelectListItem> genres = await this.genreService.GetAllGenres();            
            return this.Ok(genres);
        }
    }
}
