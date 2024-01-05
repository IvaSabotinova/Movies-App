using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> moviesRepo;        
        private readonly IMapper mapper;

        public MovieService(
            IRepository<Movie> moviesRepo,           
            IMapper mapper)
        {
            this.moviesRepo = moviesRepo;            
            this.mapper = mapper;
        }

        public async Task<Movie> CreateMovie(MovieDto movieDto, string userId)
        {
            Movie newMovie = this.mapper.Map<Movie>(movieDto);
            newMovie.ApplicationUserId = userId;
            await this.moviesRepo.AddAsync(newMovie);
            await this.moviesRepo.SaveChangesAsync();

            return newMovie;
        }

        public async Task<Movie> GetMovieById(string movieId)
          => await this.moviesRepo.All().FirstOrDefaultAsync(x => x.Id == movieId);

        public async Task<MovieDetailsDto> GetMovieDetails(string movieId)
        => await this.moviesRepo.AllAsNoTracking()
                .Where(x => x.Id == movieId)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Genre)
                .ProjectTo<MovieDetailsDto>(this.mapper.ConfigurationProvider)
                .FirstAsync();

        public async Task<Movie> UpdateMovie(string movieId, MovieDto movieDto)
        {
            Movie movieToEdit = await this.GetMovieById(movieId)
                ?? throw new NullReferenceException(MovieDoesNotExist);

            movieToEdit.Title = movieDto.Title;
            movieToEdit.GenreId = movieDto.GenreId;
            movieToEdit.Description = movieDto.Description;
            movieToEdit.Duration = movieDto.Duration;
            movieToEdit.ReleaseDate = movieDto.ReleaseDate;
            movieToEdit.ImageUrl = movieDto.ImageUrl;

            this.moviesRepo.Update(movieToEdit);
            await this.moviesRepo.SaveChangesAsync();
            return movieToEdit;
        }

        public async Task DeleteMovie(string movieId)
        {
            Movie movieToDelete = await this.GetMovieById(movieId)
                ?? throw new NullReferenceException(MovieDoesNotExist);

            this.moviesRepo.Delete(movieToDelete);
            await this.moviesRepo.SaveChangesAsync();
        }

        public async Task<IEnumerable<MovieInListDto>> GetAll()
        {
            return await this.moviesRepo.AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .ProjectTo<MovieInListDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

    }
}
