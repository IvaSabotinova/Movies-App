using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWebApi.Data;

namespace Movies_WebApi.Data.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = "0a492052-f154-4fff-a2eb-3999d0387535",
                    Name = "Drama",
                },
                new Genre
                {
                    Id = "01ac1390-aea0-4ffc-8275-bce17cd54072",
                    Name = "History",
                },
                new Genre
                {
                     Id = "02b16bb6-0164-4143-b6b8-5a470b5d9eb4",
                     Name = "Fantasy",
                },
                new Genre
                {
                      Id = "df4b7cce-f599-483f-acf6-7d2af941853f",
                      Name = "Action",
                },
                new Genre
                {
                      Id = "e226393d-c715-4d6e-bd0b-0dca06108336",
                      Name = "Comedy",
                },
                new Genre
                {
                      Id = "380b3fe3-e7b5-46bf-8bfd-65bf99031043",
                      Name = "Animation",
                },
                new Genre
                {
                    Id= "10a30a24-7221-4585-b330-0c9efc16af35",
                    Name = "Adventure"
                },
                new Genre
                {
                    Id = "f88d69a3-a968-4789-ab94-812d13fb5c76",
                    Name = "Horror"
                },
                new Genre
                {
                    Id = "f6ad08bd-4b20-4516-a874-8b74bc200c28",
                    Name = "Thriller"
                });
        }
    }
}
