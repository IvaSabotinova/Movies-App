using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies_WebApi.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole()
                {
                    Id = "852e2785-b4e5-4aaf-a1cb-ead009d712e9",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = "9714cc66-6d8c-4597-8539-c800bfe8e463"
                },
                new IdentityRole()
                {
                    Id = "f9f55e41-022f-47ba-9167-6f301eb2ab07",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "4279b556-7973-4977-994e-a358fe7971e2"
                });        
        }
    }
}
