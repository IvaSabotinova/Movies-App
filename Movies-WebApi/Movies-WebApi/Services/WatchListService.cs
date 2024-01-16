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
        public async Task<WatchList> AddToWatchList(WatchListItemDto watchListItemDto)
        {
            WatchList newWatchListItem = this.mapper.Map<WatchList>(watchListItemDto);
            await this.watchListRepo.AddAsync(newWatchListItem);
            await this.watchListRepo.SaveChangesAsync();

            return newWatchListItem;
        }

        public async Task<bool> WatchListItemExist(string userId, string movieId)
        => await this.watchListRepo.AllAsNoTracking()
                .AnyAsync(x=>x.ApplicationUserId == userId && x.MovieId == movieId);
        

        public async Task<IEnumerable<WatchListMovieDetailsDto>> GetWatchList(string userId)
        => await this.watchListRepo.AllAsNoTracking()
               .Where(x => x.ApplicationUserId == userId)
               .Include(x => x.Movie)
               .Select(x => x.Movie)
               .ProjectTo<WatchListMovieDetailsDto>(this.mapper.ConfigurationProvider)
               .ToListAsync();

        public async Task RemoveWatchListMovie(WatchListItemDto watchListItemDto)
        {
            WatchList watchListItem  = await this.watchListRepo.All()
                .FirstOrDefaultAsync(x=>x.ApplicationUserId == watchListItemDto.ApplicationUserId
                && x.MovieId == watchListItemDto.MovieId)
                ?? throw new NullReferenceException(WatchListNotExist);

            this.watchListRepo.Delete(watchListItem);
            await this.watchListRepo.SaveChangesAsync();
        }

    }
}
