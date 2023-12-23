using System.ComponentModel.DataAnnotations;

namespace MoviesWebApi.Data.Dto
{
    public class MovieInListDto
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }
       
        public double Rating { get; set; }
    }
}
