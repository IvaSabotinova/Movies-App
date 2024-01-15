using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

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
        public async Task<WatchList> AddToWatchList(WatchListDto watchListDto)
        {
            WatchList newWatchList = this.mapper.Map<WatchList>(watchListDto);
            await this.watchListRepo.AddAsync(newWatchList);
            await this.watchListRepo.SaveChangesAsync();

            return newWatchList;
        }

        public async Task<IEnumerable<WatchListSingleMovieDto>> GetWatchList(string userId)
        => await this.watchListRepo.AllAsNoTracking()
               .Where(x => x.ApplicationUserId == userId)
               .Include(x => x.Movie)
               .Select(x => x.Movie)
               .ProjectTo<WatchListSingleMovieDto>(this.mapper.ConfigurationProvider)
               .ToListAsync();

        
    }
}
