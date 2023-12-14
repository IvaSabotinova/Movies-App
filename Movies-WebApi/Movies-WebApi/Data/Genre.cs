using System.ComponentModel.DataAnnotations;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Data
{
    public class Genre
    {
        public Genre()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Movies = new HashSet<Movie>();
        }
        public string Id { get; set; }

        [MaxLength(GenreNameMaxLength)]
        public string Name { get; set; } = null!;
        public virtual ICollection<Movie> Movies { get; set; }
    }
}