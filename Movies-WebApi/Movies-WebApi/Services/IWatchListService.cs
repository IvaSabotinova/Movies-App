using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public interface IWatchListService
    {
        Task<WatchList> AddToWatchList(WatchListMovieDto watchListMovieDto);

        Task<IEnumerable<WatchListMovieDetailsDto>> GetWatchList(string userId);

        Task RemoveWatchListMovie(WatchListMovieDto watchListMovieDto);

    }
}
