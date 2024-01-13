using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Models;
using MoviesWebApi.Services;
using System.Net;
using static MoviesWebApi.Data.Constants;

namespace Movies_WebApi.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/ratings")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService ratingService;
        private readonly ApiResponse apiResponse;

        public RatingController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
            this.apiResponse = new ApiResponse();
        }

        [HttpGet("{userId}/{movieId}")]

        public async Task<ActionResult<ApiResponse>> GetRatingExist(string userId, string movieId)
        {
            try
            {
                if (userId == null || movieId == null)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.ErrorMessages = new List<string> { UserMovieNotExits };
                    return this.BadRequest(this.apiResponse);
                }
                else
                {
                    bool result = await this.ratingService.RatingExists(userId, movieId);
                    if (result)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                        this.apiResponse.Result = true;
                        return this.Ok(apiResponse);
                    }
                    else
                    {
                        //  this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.Result = false;
                        return this.Ok(apiResponse);
                    }
                }
            }
            catch (Exception ex)
            {
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
                return this.apiResponse;
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> CreateUpdateRating(string userId, string movieId, int rating)
        {
            try
            {
                if (userId == null || movieId == null)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.ErrorMessages = new List<string> { UserMovieNotExits };
                    return this.BadRequest(this.apiResponse);
                }
                UserMovieRating userMovieRating = await this.ratingService.AddUpdateRating(userId, movieId, rating);
                this.apiResponse.HttpStatusCode = HttpStatusCode.Created;
                this.apiResponse.Result = userMovieRating;
                return this.Ok(this.apiResponse);
            }
            catch (Exception ex)
            {
                this.apiResponse.IsSuccess = false;
                // this.apiResponse.ErrorMessages = new List<string> { ex.ToString() };
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
            }
            return this.apiResponse;
        }
    }
}
