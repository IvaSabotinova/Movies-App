using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public interface IWatchListService
    {
        Task<WatchList> AddToWatchList(WatchListDto watchListDto);

        Task<IEnumerable<WatchListSingleMovieDto>> GetWatchList(string userId);

    }
}
