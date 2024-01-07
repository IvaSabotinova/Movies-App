using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;
using MoviesWebApi.Data.Models;
using MoviesWebApi.Services;
using System.Net;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Controllers
{
    //[Route("api/[controller]")] 
    [Route("api/Movies")] //if controller name changes route does not get updated
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;      
        private readonly ApiResponse apiResponse;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;        
            this.apiResponse = new ApiResponse();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> CreateMovie(MovieDto movieCreateDto)
        {                            
            try
            {
                if (ModelState.IsValid)
                {
                    string? currentUserId = this.User.FindFirst("id")?.Value;
                    if (currentUserId == null)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { UserNotFound };
                        return this.BadRequest(this.apiResponse);
                    }
                    Movie newMovie = await this.movieService.CreateMovie(movieCreateDto, currentUserId);
                    this.apiResponse.HttpStatusCode = HttpStatusCode.Created;
                    this.apiResponse.Result = newMovie;
                    return this.CreatedAtRoute("GetMovie", new { id = newMovie.Id }, this.apiResponse);
                 
                }
                else
                {
                    this.apiResponse.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                this.apiResponse.IsSuccess = false;
               // this.apiResponse.ErrorMessages = new List<string> { ex.ToString() };
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
            }
            return this.apiResponse;
        }

        [HttpGet("{id}", Name = "GetMovie")]

        public async Task<IActionResult> GetMovie(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                return this.BadRequest(this.apiResponse);
            }
            MovieDetailsDto movieDto = await this.movieService.GetMovieDetails(id);
            if (movieDto == null)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string> { MovieDoesNotExist };
                return this.NotFound(this.apiResponse);
            }
            this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
            this.apiResponse.Result = movieDto;
            return this.Ok(this.apiResponse);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> UpdateMovie(string id, MovieDto movieDto)
        {
            try
            {
                if (ModelState.IsValid)
                {                   
                    Movie editedMovie = await this.movieService.UpdateMovie(id, movieDto);
                    this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                    this.apiResponse.Result = editedMovie;
                    return this.Ok(this.apiResponse);
                }
                else
                {
                    this.apiResponse.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
            }
            return this.apiResponse;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
            this.apiResponse.Result = await this.movieService.GetAll();
            return this.Ok(this.apiResponse);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<ApiResponse>> DeleteMovie(string id)
        {
            try
            {
                await this.movieService.DeleteMovie(id);
                this.apiResponse.HttpStatusCode = HttpStatusCode.NoContent;
                return this.Ok(this.apiResponse);
            }
            catch (Exception ex)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
            }

            return this.apiResponse;
        }
    }
}
