namespace MoviesWebApi.Services
{
    using MoviesWebApi.Data.Dto;
    public interface IGenreService
    {
        Task<IEnumerable<GenreDto>> GetAllGenres();
    }
}
