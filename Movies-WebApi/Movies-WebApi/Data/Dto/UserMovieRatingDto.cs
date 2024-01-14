using System.ComponentModel.DataAnnotations;

namespace MoviesWebApi.Data.Dto
{
    public class UserMovieRatingDto
    {
        public string MovieId { get; set; }

        public string ApplicationUserId { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }
    }
}
