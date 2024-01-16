using System.ComponentModel.DataAnnotations;

namespace MoviesWebApi.Data
{
    public class UserMovieRating
    {
        public string MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public string ApplicationUserId { get; set; } //user who rated for the movie

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }
       
    }
}
