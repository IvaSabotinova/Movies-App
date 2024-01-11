using MoviesWebApi.Data.Models;

namespace MoviesWebApi.Data.Dto
{
    public class MoviesListDto : PagingModel
    {
        public IEnumerable<MovieInListDto> Movies { get; set; }

        public string? SearchTerm { get; set; }

        public string? GenreIdFilter { get; set; }  

        public string? Sort { get; set; }

    }
}
