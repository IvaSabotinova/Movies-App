using MoviesWebApi.Data;

namespace MoviesWebApi.Services
{
    public interface IRatingService
    {
        Task<bool> RatingExists(string userId, string movieId);

        Task<UserMovieRating>AddUpdateRating(string userId, string movieId, int rating);
                
    }
}
