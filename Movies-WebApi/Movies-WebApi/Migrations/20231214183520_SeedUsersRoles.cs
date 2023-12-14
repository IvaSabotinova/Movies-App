using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class SeedUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "852e2785-b4e5-4aaf-a1cb-ead009d712e9", "9714cc66-6d8c-4597-8539-c800bfe8e463", "Administrator", "ADMINISTRATOR" },
                    { "f9f55e41-022f-47ba-9167-6f301eb2ab07", "4279b556-7973-4977-994e-a358fe7971e2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "595fdbef-2f26-4d9e-8b59-07a46309ac7c", 0, "501a91af-219d-4ff3-b3b8-ae606dbc828a", "admin@abv.bg", true, false, null, "ADMIN@ABV.BG", "ADMIN", "AQAAAAEAACcQAAAAEFfGnR5Jd32c4YASGDZDEG8RB5TuBWlrjW1l+EHEZexQKVFzb5sUzCHyEd9RVlW2Jg==", "+359889694030", false, "72961cc8-9558-4700-8a36-19adf9e1f5c0", false, "admin" },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", 0, "fcf159fe-f974-4e71-b836-0cfdf3b537e9", "george@abv.bg", true, false, null, "GEORGE@ABV.BG", "GEORGE", "AQAAAAEAACcQAAAAEAH5FSP2/NHA8+uei89nw4P2TlPg+J2IbowYZKEqNr7d+rioHIJCzTFczJK0IB0YjA==", "+359888111111", false, "5cf80d8c-a6a5-4594-84a3-7b5828c21191", false, "George" },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", 0, "7ff7264b-fb40-4d70-a3e4-b967b6323d2a", "katya@abv.bg", true, false, null, "KATYA@ABV.BG", "KATYA", "AQAAAAEAACcQAAAAEBX7r9bkpNePhhnT2KsAALz/dYotd9NSt7HRYnfEbCclmbnM574Dhm9GLvbARVoBAQ==", "+359888222222", false, "42e02d95-161f-4676-a5e1-410b07c0e3d0", false, "Katya" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "852e2785-b4e5-4aaf-a1cb-ead009d712e9", "595fdbef-2f26-4d9e-8b59-07a46309ac7c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f9f55e41-022f-47ba-9167-6f301eb2ab07", "b276b391-ab92-41f7-a4a6-f29e8525a3f5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f9f55e41-022f-47ba-9167-6f301eb2ab07", "c769b464-2126-4249-9809-7b8aad21d7fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "852e2785-b4e5-4aaf-a1cb-ead009d712e9", "595fdbef-2f26-4d9e-8b59-07a46309ac7c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9f55e41-022f-47ba-9167-6f301eb2ab07", "b276b391-ab92-41f7-a4a6-f29e8525a3f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9f55e41-022f-47ba-9167-6f301eb2ab07", "c769b464-2126-4249-9809-7b8aad21d7fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "852e2785-b4e5-4aaf-a1cb-ead009d712e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9f55e41-022f-47ba-9167-6f301eb2ab07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa");
        }
    }
}
