using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movies_WebApi.Data.Configuration;
using MoviesWebApi.Data.Configuration;

namespace MoviesWebApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<UserMovieRating> UsersMoviesRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserMovieRating>()
              .HasKey(x => new { x.ApplicationUserId, x.MovieId });

            builder.Entity<UserMovieRating>()
               .HasOne(x => x.ApplicationUser)
               .WithMany(u => u.RatedMovies)
               .HasForeignKey(uv => uv.ApplicationUserId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
              .HasMany(u => u.Movies)
              .WithOne(m => m.ApplicationUser)
              .HasForeignKey(m => m.ApplicationUserId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new UserMovieVoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
