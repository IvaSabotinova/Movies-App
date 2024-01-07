using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Data.Dto
{
    public class MovieDto
    {
        [Required]
        [StringLength(MovieTitleMaxLength, MinimumLength = MovieTitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        public string GenreId { get; set; } = null!;

        public IEnumerable<SelectListItem> Genres { get; set; } = new List<SelectListItem>();

        [Required]
        [StringLength(MovieDescriptionMaxLength, MinimumLength = MovieDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int Duration { get; set; } //in minutes

        public DateTime ReleaseDate { get; set; }

         [Required]
         //[RegularExpression(ImageUrlRegex)]
         public string ImageUrl { get; set; } = null!;

    }
}
