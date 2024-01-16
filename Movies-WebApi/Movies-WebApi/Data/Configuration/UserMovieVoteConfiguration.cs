using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoviesWebApi.Data.Configuration
{
    public class UserMovieVoteConfiguration : IEntityTypeConfiguration<UserMovieRating>
    {
        public void Configure(EntityTypeBuilder<UserMovieRating> builder)
        {
            builder.HasData(
                new UserMovieRating()
                {                    
                    MovieId = "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 8,
                },
                new UserMovieRating()
                {
                    MovieId = "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 6,
                }, 
                new UserMovieRating()
                {
                    MovieId = "515ae48d-59c7-4abb-a15c-233c077139aa",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    MovieId = "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 8,
                },   
                new UserMovieRating()
                {
                    MovieId = "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    MovieId = "9feac707-77eb-456b-a5e0-483c9fc65c96",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 6,
                }, 
                new UserMovieRating()
                {
                    MovieId = "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 8,
                }, 
                new UserMovieRating()
                {
                    MovieId = "947c6c71-4273-4ccb-b0da-422f89f7d378",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 6,
                }, 
                new UserMovieRating()
                {
                    MovieId = "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 6,                     
                }, 
                new UserMovieRating()
                {
                    MovieId = "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 3,
                }, 
                new UserMovieRating()
                {
                    MovieId = "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    MovieId = "9867b25f-69af-40ff-b5df-b461eb5232df",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    MovieId = "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 8,
                },
                new UserMovieRating()
                {
                    MovieId = "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 6,
                },
                new UserMovieRating()
                {
                    MovieId = "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 7,
                });
        }
    }
}
