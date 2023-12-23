﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<SelectListItem>> GetAllGenres();

        Task<Movie> CreateMovie(MovieDto movieDto, string userId);

        Task<Movie> GetMovieById(string movieId);

        Task<MovieDetailsDto> GetMovieDetails(string movieId);

        Task<Movie> UpdateMovie(string movieId, MovieDto movieDto);

        Task DeleteMovie(string movieId);

        Task<IEnumerable<MovieInListDto>> GetAll();


    }
}
