﻿using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;
using MoviesWebApi.Data.Models;
using MoviesWebApi.Services;
using System.Net;
using System.Security.Claims;

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
        public async Task<ActionResult<ApiResponse>> CreateMovie([FromForm] MovieCreateDto movieCreateDto)
        {
            string currentUserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            try
            {
                if (ModelState.IsValid)
                {
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
                this.apiResponse.ErrorMessages = new List<string> { ex.ToString() };
            }
            return this.apiResponse;
        }

        [HttpGet("{id}", Name = "GetMovie")]

        public async Task<IActionResult> GetMovie(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.BadRequest;
                return BadRequest(this.apiResponse);
            }
            Movie movie = await this.movieService.GetMovieById(id);
            if (movie == null)
            {
                this.apiResponse.HttpStatusCode = HttpStatusCode.NotFound;
                return NotFound(this.apiResponse);
            }
            this.apiResponse.HttpStatusCode = HttpStatusCode.OK;
            this.apiResponse.Result = movie;
            return Ok(this.apiResponse);
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
