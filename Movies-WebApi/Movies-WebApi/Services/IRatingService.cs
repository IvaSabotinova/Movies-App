using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public interface IRatingService
    {
        Task<bool> UserExists(string userId);

        Task<bool> MovieExists(string movieId);

        Task<bool> RatingExists(string userId, string movieId);      

        Task<UserMovieRating> GetUserMovieRating(string userId, string movieId);

        Task<UserMovieRating>AddRating(UserMovieRatingDto userMovieRatingDto);

        Task<UserMovieRating>UpdateRating(UserMovieRatingDto userMovieRatingDto);

    }
}
