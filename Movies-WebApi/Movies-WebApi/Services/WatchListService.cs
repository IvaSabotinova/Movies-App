using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Services
{
    public class WatchListService : IWatchListService
    {
        private readonly IRepository<WatchList> watchListRepo;
        private readonly IMapper mapper;

        public WatchListService(
            IRepository<WatchList> watchListRepo,
            IMapper mapper)
        {
            this.watchListRepo = watchListRepo;
            this.mapper = mapper;
        }
        public async Task<WatchList> AddToWatchList(WatchListMovieDto watchListMovieDto)
        {
            WatchList newWatchList = this.mapper.Map<WatchList>(watchListMovieDto);
            await this.watchListRepo.AddAsync(newWatchList);
            await this.watchListRepo.SaveChangesAsync();

            return newWatchList;
        }

        public async Task<IEnumerable<WatchListMovieDetailsDto>> GetWatchList(string userId)
        => await this.watchListRepo.AllAsNoTracking()
               .Where(x => x.ApplicationUserId == userId)
               .Include(x => x.Movie)
               .Select(x => x.Movie)
               .ProjectTo<WatchListMovieDetailsDto>(this.mapper.ConfigurationProvider)
               .ToListAsync();

        public async Task RemoveWatchListMovie(WatchListMovieDto watchListMovieDto)
        {
            WatchList watchListMovie  = await this.watchListRepo.All()
                .FirstOrDefaultAsync(x=>x.ApplicationUserId == watchListMovieDto.ApplicationUserId
                && x.MovieId == watchListMovieDto.MovieId)
                ?? throw new NullReferenceException(WatchListNotExist);

            this.watchListRepo.Delete(watchListMovie);
            await this.watchListRepo.SaveChangesAsync();
        }
    }
}
