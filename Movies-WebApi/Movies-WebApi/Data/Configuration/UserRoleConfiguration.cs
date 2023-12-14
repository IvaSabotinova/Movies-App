using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies_WebApi.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                    RoleId = "852e2785-b4e5-4aaf-a1cb-ead009d712e9",
                },
                new IdentityUserRole<string>
                {
                    UserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    RoleId = "f9f55e41-022f-47ba-9167-6f301eb2ab07"
                },
                new IdentityUserRole<string>
                {
                    UserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    RoleId = "f9f55e41-022f-47ba-9167-6f301eb2ab07"
                });
        }
    }
}
