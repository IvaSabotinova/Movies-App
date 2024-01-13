using Microsoft.AspNetCore.Identity;

namespace MoviesWebApi.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Movies = new HashSet<Movie>();
            this.RatedMovies = new HashSet<UserMovieRating>();
        }

        public virtual ICollection<Movie> Movies { get; set; }

        public virtual ICollection<UserMovieRating> RatedMovies { get; set; }
    }
}
