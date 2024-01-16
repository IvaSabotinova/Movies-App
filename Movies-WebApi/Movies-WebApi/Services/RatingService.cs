using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRepository<UserMovieRating> userMovieRatingRepo;
        private readonly IRepository<Movie> movieRepo;
        private readonly IRepository<ApplicationUser> userRepo;
        private readonly IMapper mapper;

        public RatingService(
            IRepository<UserMovieRating> userMovieRatingRepo,
            IRepository<Movie> movieRepo,
            IRepository<ApplicationUser> userRepo,
            IMapper mapper)
        {
            this.userMovieRatingRepo = userMovieRatingRepo;
            this.movieRepo = movieRepo;
            this.userRepo = userRepo;
            this.mapper = mapper;
        }

        public async Task<bool> UserExists(string userId)
        => await this.userRepo.AllAsNoTracking()
                .AnyAsync(x => x.Id == userId);


        public async Task<bool> MovieExists(string movieId)
        => await this.movieRepo.AllAsNoTracking()
            .AnyAsync(x => x.Id == movieId);

        public async Task<bool> RatingExists(string userId, string movieId)
        => await this.userMovieRatingRepo.AllAsNoTracking()
                .AnyAsync(x => x.ApplicationUserId == userId && x.MovieId == movieId);

        public async Task<UserMovieRating> GetUserMovieRating(string userId, string movieId)
        => await this.userMovieRatingRepo.All()
                 .FirstOrDefaultAsync(x => x.ApplicationUserId == userId && x.MovieId == movieId);

        public async Task<UserMovieRating> AddRating(UserMovieRatingDto userMovieRatingDto)
        {
            UserMovieRating newRating = this.mapper.Map<UserMovieRating>(userMovieRatingDto);
            await this.userMovieRatingRepo.AddAsync(newRating);
            await this.userMovieRatingRepo.SaveChangesAsync();
            return newRating;
        }

        public async Task<UserMovieRating> UpdateRating(UserMovieRatingDto userMovieRatingDto)
        {
            UserMovieRating ratingToUpdate =
                await this.GetUserMovieRating(userMovieRatingDto.ApplicationUserId, userMovieRatingDto.MovieId)
               ?? throw new NullReferenceException(UserMovieRatingNotExist);

            ratingToUpdate.Rating = userMovieRatingDto.Rating;
            await this.userMovieRatingRepo.SaveChangesAsync();
            return ratingToUpdate;
        }

    }
}
