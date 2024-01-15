namespace MoviesWebApi.Data
{
    public class WatchList
    {
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
