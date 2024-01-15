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
    // [Route("api/[controller]")]
    [Route("api/watchList")]
    [ApiController]
    public class WatchListController : ControllerBase
    {
        private readonly IWatchListService watchListService;
        private readonly IRatingService ratingService;
        private readonly ApiResponse apiResponse;

        public WatchListController(
            IWatchListService watchListService,
            IRatingService ratingService)
        {
            this.watchListService = watchListService;
            this.ratingService = ratingService;
            this.apiResponse = new ApiResponse();
        }

        [Authorize]
        [HttpPost]

        public async Task<ActionResult<ApiResponse>> AddToWatchList(WatchListDto watchListDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool userExists = await this.ratingService.UserExists(watchListDto.ApplicationUserId);
                    bool movieExists = await this.ratingService.MovieExists(watchListDto.MovieId);
                    if (watchListDto.ApplicationUserId == null || watchListDto.MovieId == null)
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
                    WatchList newWatchListMovie = await this.watchListService.AddToWatchList(watchListDto);
                    this.apiResponse.HttpStatusCode = HttpStatusCode.Created;
                    this.apiResponse.Result = newWatchListMovie;
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

       // [Authorize]
        [HttpGet("{userId}")]

        public async Task<ActionResult<ApiResponse>> GetWatchList(string userId)
        {
            try
            {
                bool userExists = await this.ratingService.UserExists(userId);
                if (!userExists)
                {
                    this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                    this.apiResponse.IsSuccess = false;
                    this.apiResponse.ErrorMessages = new List<string> { UserNotFound };
                    return this.NotFound(this.apiResponse);
                }
                IEnumerable<WatchListSingleMovieDto> watchList = await this.watchListService.GetWatchList(userId);
                this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
                this.apiResponse.Result = watchList;
                return this.Ok(this.apiResponse);

            }
            catch (Exception ex)
            {
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
                return this.apiResponse;
            }
        }

    }
}
