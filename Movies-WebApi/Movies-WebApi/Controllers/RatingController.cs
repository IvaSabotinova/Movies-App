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
                bool userExists = await this.ratingService.UserExists(userId);
                bool movieExists = await this.ratingService.MovieExists(movieId);
                if (userId == null || movieId == null)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.Result = false;
                    this.apiResponse.ErrorMessages = new List<string> { UserMovieNotExits };
                    return this.BadRequest(this.apiResponse);
                }
                else if (!userExists)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.Result = false;
                    this.apiResponse.ErrorMessages = new List<string> { UserNotFound };
                    return this.NotFound(this.apiResponse);

                }
                else if (!movieExists)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.Result = false;
                    this.apiResponse.ErrorMessages = new List<string> { MovieDoesNotExist };
                    return this.NotFound(this.apiResponse);
                }
                else
                {
                    bool result = await this.ratingService.RatingExists(userId, movieId);
                    if (result)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                        this.apiResponse.IsSuccess = true;
                        this.apiResponse.Result = true;
                        return this.Ok(apiResponse);
                    }
                    else
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                        this.apiResponse.IsSuccess = true;
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
        public async Task<ActionResult<ApiResponse>> CreateRating(UserMovieRatingDto userMovieRatingDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool userExists = await this.ratingService.UserExists(userMovieRatingDto.ApplicationUserId);
                    bool movieExists = await this.ratingService.MovieExists(userMovieRatingDto.MovieId);
                    if (userMovieRatingDto.ApplicationUserId == null || userMovieRatingDto.MovieId == null)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { UserMovieNotExits };
                        return this.BadRequest(this.apiResponse);
                    }
                    else if (!userExists)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { UserNotFound };
                        return this.NotFound(this.apiResponse);

                    }
                    else if (!movieExists)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { MovieDoesNotExist };
                        return this.NotFound(this.apiResponse);
                    }
                    UserMovieRating userMovieRating = await this.ratingService
                        .AddRating(userMovieRatingDto);
                    this.apiResponse.HttpStatusCode = HttpStatusCode.Created;
                    this.apiResponse.Result = userMovieRating;
                    return this.Ok(this.apiResponse);
                }
                else
                {
                    this.apiResponse.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                this.apiResponse.IsSuccess = false;               
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
            }
            return this.apiResponse;
        }

        [HttpPatch]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> UpdateRating(UserMovieRatingDto userMovieRatingDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool userExists = await this.ratingService.UserExists(userMovieRatingDto.ApplicationUserId);
                    bool movieExists = await this.ratingService.MovieExists(userMovieRatingDto.MovieId);
                    if (userMovieRatingDto.ApplicationUserId == null || userMovieRatingDto.MovieId == null)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { UserMovieNotExits };
                        return this.BadRequest(this.apiResponse);
                    }
                    else if (!userExists)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { UserNotFound };
                        return this.NotFound(this.apiResponse);

                    }
                    else if (!movieExists)
                    {
                        this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                        this.apiResponse.IsSuccess = false;
                        this.apiResponse.ErrorMessages = new List<string> { MovieDoesNotExist };
                        return this.NotFound(this.apiResponse);
                    }
                    UserMovieRating editedRating = await this.ratingService
                        .UpdateRating(userMovieRatingDto);
                    this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                    this.apiResponse.Result = editedRating;
                    return this.Ok(this.apiResponse);
                }
                else
                {
                    this.apiResponse.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                this.apiResponse.IsSuccess = false;              
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
            }
            return this.apiResponse;
        }
    }
}
