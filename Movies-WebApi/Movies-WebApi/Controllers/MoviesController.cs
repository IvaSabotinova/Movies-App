using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Data.Models;
using MoviesWebApi.Services;
using System.Net;

namespace MoviesWebApi.Controllers
{
    //[Route("api/[controller]")] 
    [Route("api/Movies")] //if controller name changes route does not get updated
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;
        private readonly ApiResponse apiResponse;

        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
            this.apiResponse = new ApiResponse();
        }

        [HttpGet]

        public async Task<IActionResult> GetAll() 
        { 
            this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
            this.apiResponse.Result = await this.movieService.GetAll();
            return Ok(this.apiResponse);
        }
    }
}
