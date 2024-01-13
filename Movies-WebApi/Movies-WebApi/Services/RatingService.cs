using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;

namespace MoviesWebApi.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRepository<UserMovieRating> userMovieRatingRepo;

        public RatingService(IRepository<UserMovieRating> userMovieRatingRepo)
        {
            this.userMovieRatingRepo = userMovieRatingRepo;
        }

        public async Task<bool> RatingExists(string userId, string movieId)
        => await this.userMovieRatingRepo.AllAsNoTracking()
                .AnyAsync(x => x.MovieId == movieId && x.ApplicationUserId == userId);

        public async Task<UserMovieRating> AddUpdateRating(string userId, string movieId, int rating)
        {
            UserMovieRating dbRating = await this.userMovieRatingRepo.AllAsNoTracking()
                 .FirstOrDefaultAsync(x => x.ApplicationUserId == userId && x.MovieId == movieId);

            if (dbRating == null)
            {
                UserMovieRating newRating = new UserMovieRating()
                {
                    ApplicationUserId = userId,
                    MovieId = movieId,
                    Rating = rating,                     
                };
                await this.userMovieRatingRepo.AddAsync(newRating);
                await this.userMovieRatingRepo.SaveChangesAsync();
                return newRating;
            }
            else
            {
                dbRating.Rating = rating;
                await this.userMovieRatingRepo.SaveChangesAsync();
                return dbRating;
            }           

        }

    }
}
