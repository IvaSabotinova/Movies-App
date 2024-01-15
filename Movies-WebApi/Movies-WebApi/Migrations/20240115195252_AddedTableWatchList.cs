using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class AddedTableWatchList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "UsersMoviesRatings");

            migrationBuilder.CreateTable(
                name: "WatchList",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchList", x => new { x.ApplicationUserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_WatchList_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchList_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4fb3020f-30c0-4076-a220-ff382ac3349a", "AQAAAAEAACcQAAAAEEje+1oVGw6g2lKIk9B87CjGDIAzmUTHHGAEr/c5nFn/YosH+x/rYf/lbtuD+l8vaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a6cd86e-7959-40e0-b7f8-6b7f9f527a35", "AQAAAAEAACcQAAAAEJo8PmDBUCEXw0kkycOPLFtu1/51zODdoYu+XdByrIiVHqU8jOtgyu9H4nJotfX+TQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ac0c4ca-9251-446b-a719-f83bafe866b1", "AQAAAAEAACcQAAAAEA6OSFAyUBPPq0Eggr98NQXA6HSMpXI9lHcSTLkaRQSv7mX4OhVOmzVznXNSzoh8Hg==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 3, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 2, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 13, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 6, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 7, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 8, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 14, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 4, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 5, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 15, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 10, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 1, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 12, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 11, 21, 52, 52, 153, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_MovieId",
                table: "WatchList",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WatchList");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "UsersMoviesRatings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f69af44-1fb6-4ce9-b2b6-b5344651de4a", "AQAAAAEAACcQAAAAEAsJmVwlAMyRdeM+xLLpqcU3Imzy8wwZP+nG5WRhWXHwDimDbMUBzA8A4fbJMCReZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb370623-bfea-4d2c-89d2-1aa8c3561521", "AQAAAAEAACcQAAAAEPzAr0UFPxO7K7sgGDAohUbgbCWaGilkS3aTrY5okqbjZU/JjOWWin6n5xuDMWTpvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b158e71d-667f-40d9-846b-8fe9db8f205f", "AQAAAAEAACcQAAAAEIm9jkdJdrKrSr1+UxCJUXAPOAvxX6aOiKH73NLOSFRYeTMhIQqLrumehngpZqVVrw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 2, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 1, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 8, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 12, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 5, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 6, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 7, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 13, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 3, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 4, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 14, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 31, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 11, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 10, 0, 4, 8, 188, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "0f744962-21c0-4dcf-af3f-c3b91ddf321b" },
                column: "Id",
                value: "0a799f60-91ef-4879-a8d6-84ccf8c4da43");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "4abeaca8-0683-45ac-acc1-e628f78a9bc1" },
                column: "Id",
                value: "7b7e828e-dad9-44ab-b3e9-38dfcf31aba1");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "74d857da-6b3f-4d25-9b18-e0dbeff061a6" },
                column: "Id",
                value: "324027ee-90f2-429a-9e72-b6c36a4c01e4");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "81689a51-4cb2-483f-a3d6-da6107da4ed0" },
                column: "Id",
                value: "0991b640-e9ee-4d81-9d72-ce9073e401ec");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "9867b25f-69af-40ff-b5df-b461eb5232df" },
                column: "Id",
                value: "d839acbc-ee94-4fb7-bda0-715fe5b5a901");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "9c762863-ba47-4ab2-acbc-930a31fa2dfd" },
                column: "Id",
                value: "7914edbe-b15c-4c9b-81ae-bf4a8f32f7c2");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "a127a2e1-a4f9-46ac-a687-ea95d77074bb" },
                column: "Id",
                value: "a104b0db-1547-4e75-8b94-9a6b879a1444");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "4cbe3454-a451-418b-8ea0-f1f5fe540002" },
                column: "Id",
                value: "8c77caa3-c1e4-4fad-86d3-68a1478cab10");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "515ae48d-59c7-4abb-a15c-233c077139aa" },
                column: "Id",
                value: "4e4ab8ea-93c8-4e0d-aa73-ce617f5d90a7");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "947c6c71-4273-4ccb-b0da-422f89f7d378" },
                column: "Id",
                value: "22695074-2e4b-4757-a97e-7dcc049891d0");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "96b3391f-5f7d-4813-8edb-80dfd8e8f11c" },
                column: "Id",
                value: "f0080885-9e2f-446f-a100-936c17d27365");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4" },
                column: "Id",
                value: "40a3bd9e-7251-441a-b0f8-cba0174c2639");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "9feac707-77eb-456b-a5e0-483c9fc65c96" },
                column: "Id",
                value: "83e100d7-60de-403f-ba8d-f2c41e2b8008");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941" },
                column: "Id",
                value: "1ef58453-0f1e-451c-b26b-b7c981afd082");

            migrationBuilder.UpdateData(
                table: "UsersMoviesRatings",
                keyColumns: new[] { "ApplicationUserId", "MovieId" },
                keyValues: new object[] { "c769b464-2126-4249-9809-7b8aad21d7fa", "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f" },
                column: "Id",
                value: "aeed8e4a-e63a-45fa-8911-f9bd5a25fe5b");
        }
    }
}
