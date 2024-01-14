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

        public async Task<MoviesListDto> GetAll(
            int page,
            int itemsPerPage,
            string? searchTerm = null,
            string? genreIdFilter = null,
            string? sort = null)
        {
            IQueryable<Movie> moviesQuery = this.moviesRepo
                .AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string searchQuery = $"%{searchTerm.Trim().ToLower()}%";
                moviesQuery = moviesQuery.Where(x => EF.Functions.Like(x.Title.ToLower(), searchQuery));
            }

            if (!string.IsNullOrEmpty(genreIdFilter))
            {
                moviesQuery = moviesQuery.Where(x => x.GenreId == genreIdFilter);
            }

            if (!string.IsNullOrEmpty(sort))
            {
                if (sort == "A-Z")
                {
                    moviesQuery = moviesQuery.OrderBy(x => x.Title);
                }
                else if (sort == "Z-A")
                {
                    moviesQuery = moviesQuery.OrderByDescending(x => x.Title);
                }
                else if (sort == "0-10")
                {
                    moviesQuery = moviesQuery.OrderBy(x => x.Ratings.Any()
                    ? (double)x.Ratings.Sum(x => x.Rating) / x.Ratings.Count : 0);
                }
                else if( sort == "10-0")
                {
                    moviesQuery = moviesQuery.OrderByDescending(x => x.Ratings.Any()
                    ? (double)x.Ratings.Sum(x => x.Rating) / x.Ratings.Count : 0);
                }
            }

            int itemsCount = await moviesQuery.CountAsync();

            List<MovieInListDto> movies = await moviesQuery
            .ProjectTo<MovieInListDto>(this.mapper.ConfigurationProvider)
            .Skip((page - 1) * itemsPerPage)
            .Take(itemsPerPage)
            .ToListAsync();

            return new MoviesListDto()
            {
                CurrentPageNumber = page,
                ItemsPerPage = itemsPerPage,
                AllItemsCount = itemsCount,
                Movies = movies,
                SearchTerm = searchTerm,
                GenreIdFilter = genreIdFilter,
                Sort = sort,
            };
        }

    }
}
