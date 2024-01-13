using System.ComponentModel.DataAnnotations;

namespace MoviesWebApi.Data
{
    public class UserMovieRating
    {
        public UserMovieRating()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public string ApplicationUserId { get; set; } //user who voted for the movie

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
       
    }
}
