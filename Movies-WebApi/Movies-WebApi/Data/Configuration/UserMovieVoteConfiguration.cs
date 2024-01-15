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
                    //Id = "40a3bd9e-7251-441a-b0f8-cba0174c2639",
                    MovieId = "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 8,
                },
                new UserMovieRating()
                {
                    //Id = "f0080885-9e2f-446f-a100-936c17d27365",
                    MovieId = "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 6,
                }, 
                new UserMovieRating()
                {
                    //Id = "4e4ab8ea-93c8-4e0d-aa73-ce617f5d90a7",
                    MovieId = "515ae48d-59c7-4abb-a15c-233c077139aa",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    //Id = "1ef58453-0f1e-451c-b26b-b7c981afd082",
                    MovieId = "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 8,
                },   
                new UserMovieRating()
                {
                    //Id = "aeed8e4a-e63a-45fa-8911-f9bd5a25fe5b",
                    MovieId = "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    //Id = "83e100d7-60de-403f-ba8d-f2c41e2b8008",
                    MovieId = "9feac707-77eb-456b-a5e0-483c9fc65c96",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 6,
                }, 
                new UserMovieRating()
                {
                    //Id = "8c77caa3-c1e4-4fad-86d3-68a1478cab10",
                    MovieId = "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 8,
                }, 
                new UserMovieRating()
                {
                    //Id = "22695074-2e4b-4757-a97e-7dcc049891d0",
                    MovieId = "947c6c71-4273-4ccb-b0da-422f89f7d378",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    Rating = 6,
                }, 
                new UserMovieRating()
                {
                    //Id = "0991b640-e9ee-4d81-9d72-ce9073e401ec",
                    MovieId = "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 6,                     
                }, 
                new UserMovieRating()
                {
                    //Id = "324027ee-90f2-429a-9e72-b6c36a4c01e4",
                    MovieId = "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 3,
                }, 
                new UserMovieRating()
                {
                    //Id = "7914edbe-b15c-4c9b-81ae-bf4a8f32f7c2",
                    MovieId = "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    //Id = "d839acbc-ee94-4fb7-bda0-715fe5b5a901",
                    MovieId = "9867b25f-69af-40ff-b5df-b461eb5232df",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 7,
                }, 
                new UserMovieRating()
                {
                    //Id = "0a799f60-91ef-4879-a8d6-84ccf8c4da43",
                    MovieId = "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 8,
                },
                new UserMovieRating()
                {
                    //Id = "7b7e828e-dad9-44ab-b3e9-38dfcf31aba1",
                    MovieId = "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 6,
                },
                new UserMovieRating()
                {
                    //Id = "a104b0db-1547-4e75-8b94-9a6b879a1444",
                    MovieId = "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    Rating = 7,
                });
        }
    }
}
