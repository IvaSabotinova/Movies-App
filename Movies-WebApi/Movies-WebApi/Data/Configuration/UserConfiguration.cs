using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWebApi.Data;

namespace Movies_WebApi.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(this.CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser admin = new ApplicationUser()
            {
                Id = "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@ABV.BG",
                SecurityStamp = "72961cc8-9558-4700-8a36-19adf9e1f5c0",
                PhoneNumber = "+359889694030",
                EmailConfirmed = true,
            };

            admin.PasswordHash = hasher.HashPassword(admin, "admin123456");
            users.Add(admin);

            ApplicationUser user01 = new ApplicationUser()
            {
                Id = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                UserName = "George",
                NormalizedUserName = "GEORGE",
                Email = "george@abv.bg",
                NormalizedEmail = "GEORGE@ABV.BG",
                SecurityStamp = "5cf80d8c-a6a5-4594-84a3-7b5828c21191",
                PhoneNumber = "+359888111111",
                EmailConfirmed = true,
            };

            user01.PasswordHash = hasher.HashPassword(user01, "george123456");
            users.Add(user01);

            ApplicationUser user02 = new ApplicationUser()
            {
                Id = "c769b464-2126-4249-9809-7b8aad21d7fa",
                UserName = "Katya",
                NormalizedUserName = "KATYA",
                Email = "katya@abv.bg",
                NormalizedEmail = "KATYA@ABV.BG",
                SecurityStamp = "42e02d95-161f-4676-a5e1-410b07c0e3d0",
                PhoneNumber = "+359888222222",
                EmailConfirmed = true,
            };

            user02.PasswordHash = hasher.HashPassword(user02, "katya123456");
            users.Add(user02);

            return users;
        }
    }
}
