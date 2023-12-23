namespace MoviesWebApi.Data.Dto
{
    public class MovieDetailsDto
    {
        public string Id { get; set; }

       public string Title { get; set; }

        public string GenreName { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; } //in minutes

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; }

        public double Rating { get; set; }

        public string ApplicationUserUserName { get; set; }

       // public DateTime CreatedOn { get; set; }
    }
}
