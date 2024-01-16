using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public interface IWatchListService
    {
        Task<WatchList> AddToWatchList(WatchListItemDto watchListItemDto);

        Task<bool> WatchListItemExist(string userId, string movieId);

        Task<IEnumerable<WatchListMovieDetailsDto>> GetWatchList(string userId);

        Task RemoveWatchListMovie(WatchListItemDto watchListItemDto);

    }
}
