﻿using System.ComponentModel.DataAnnotations;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Data
{
    public class Movie
    {
        public Movie()
        {
            this.Id = Guid.NewGuid().ToString();
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
        public byte[] ImageData { get; set; }

        [Required]
        public string ImageMimeType { get; set; }

        [Range(1, 10.00)]
        public double Rating { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
