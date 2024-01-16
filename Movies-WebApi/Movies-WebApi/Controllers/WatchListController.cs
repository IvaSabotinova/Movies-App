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

        public async Task<ActionResult<ApiResponse>> AddToWatchList(WatchListItemDto watchListItemDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool userExists = await this.ratingService.UserExists(watchListItemDto.ApplicationUserId);
                    bool movieExists = await this.ratingService.MovieExists(watchListItemDto.MovieId);
                    if (string.IsNullOrWhiteSpace(watchListItemDto.ApplicationUserId)
                        || string.IsNullOrWhiteSpace(watchListItemDto.MovieId))
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
                    WatchList newWatchListItem = await this.watchListService.AddToWatchList(watchListItemDto);
                    this.apiResponse.HttpStatusCode = HttpStatusCode.Created;
                    this.apiResponse.Result = newWatchListItem;
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

        [Authorize]
        [HttpGet("{userId}/{movieId}")]

        public async Task<ActionResult<ApiResponse>> GetWatchListItemExist(string userId, string movieId)
        {
            try
            {
                bool userExists = await this.ratingService.UserExists(userId);
                bool movieExists = await this.ratingService.MovieExists(movieId);
                if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(movieId))
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
                    bool result = await this.watchListService.WatchListItemExist(userId, movieId);
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

        [Authorize]
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
                IEnumerable<WatchListMovieDetailsDto> watchList = await this.watchListService.GetWatchList(userId);
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

        [HttpDelete]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> DeleteWatchListMovie(WatchListItemDto watchListItemDto)
        {
            try
            {
                await this.watchListService.RemoveWatchListMovie(watchListItemDto);
                this.apiResponse.HttpStatusCode = HttpStatusCode.NoContent;
                return this.Ok(this.apiResponse);
            }
            catch (Exception ex)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                this.apiResponse.IsSuccess = false;
                this.apiResponse.ErrorMessages = new List<string> { ex.Message };
                return this.apiResponse;
            }

        }

    }
}
