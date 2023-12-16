using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesWebApi.Data;
using System.ComponentModel.DataAnnotations;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Data.Dto
{
    public class MovieCreateDto
    {
        [Required]
        //[StringLength(MovieTitleMaxLength, MinimumLength = MovieTitleMinLength)]
        public string Title { get; set; } = null!;

        //[Required]
        //[StringLength(GenreNameMaxLength, MinimumLength = GenreNameMinLength)]
        public string GenreId { get; set; }

        public IEnumerable<SelectListItem> Genres { get; set; } = new List<SelectListItem>();

        [Required]
        //[StringLength(MovieDescriptionMaxLength, MinimumLength = MovieDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int Duration { get; set; } //in minutes

        public DateTime ReleaseDate { get; set; }

        [Required]
       // [RegularExpression(ImageUrlRegex)]
        public string ImageUrl { get; set; }

    }
}
