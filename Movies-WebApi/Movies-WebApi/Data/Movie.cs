using System.ComponentModel.DataAnnotations;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Data
{
    public class Movie
    {
        public Movie()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Ratings = new HashSet<UserMovieRating>();
        }
        public string Id { get; set; }

        [MaxLength(MovieTitleMaxLength)]
        public string Title { get; set; } = null!;

        public string GenreId { get; set; }

        public virtual Genre Genre { get; set; } = null!;

        [MaxLength(MovieDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int Duration { get; set; } //in minutes

        public DateTime ReleaseDate { get; set; }

        [Required]
        public string ImageUrl { get; set; }  

        public string ApplicationUserId { get; set; } //creator of the movie

        public virtual ApplicationUser ApplicationUser { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<UserMovieRating> Ratings { get; set; }
    }
}
