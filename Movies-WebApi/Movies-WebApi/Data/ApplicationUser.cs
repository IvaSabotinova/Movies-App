using Microsoft.AspNetCore.Identity;
using MoviesWebApi.Data;

namespace MoviesWebApi.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Movies = new HashSet<Movie>();
        }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
