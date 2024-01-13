using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class ChangeNameMappingTableRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersMoviesVotes");

            migrationBuilder.CreateTable(
                name: "UsersMoviesRatings",
                columns: table => new
                {
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersMoviesRatings", x => new { x.ApplicationUserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_UsersMoviesRatings_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersMoviesRatings_Movies_MovieId",
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

            migrationBuilder.InsertData(
                table: "UsersMoviesRatings",
                columns: new[] { "ApplicationUserId", "MovieId", "Id", "Rating" },
                values: new object[,]
                {
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "0f744962-21c0-4dcf-af3f-c3b91ddf321b", "0a799f60-91ef-4879-a8d6-84ccf8c4da43", 8 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "4abeaca8-0683-45ac-acc1-e628f78a9bc1", "7b7e828e-dad9-44ab-b3e9-38dfcf31aba1", 6 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "74d857da-6b3f-4d25-9b18-e0dbeff061a6", "324027ee-90f2-429a-9e72-b6c36a4c01e4", 3 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "81689a51-4cb2-483f-a3d6-da6107da4ed0", "0991b640-e9ee-4d81-9d72-ce9073e401ec", 6 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "9867b25f-69af-40ff-b5df-b461eb5232df", "d839acbc-ee94-4fb7-bda0-715fe5b5a901", 7 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "9c762863-ba47-4ab2-acbc-930a31fa2dfd", "7914edbe-b15c-4c9b-81ae-bf4a8f32f7c2", 7 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "a127a2e1-a4f9-46ac-a687-ea95d77074bb", "a104b0db-1547-4e75-8b94-9a6b879a1444", 7 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "4cbe3454-a451-418b-8ea0-f1f5fe540002", "8c77caa3-c1e4-4fad-86d3-68a1478cab10", 8 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "515ae48d-59c7-4abb-a15c-233c077139aa", "4e4ab8ea-93c8-4e0d-aa73-ce617f5d90a7", 7 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "947c6c71-4273-4ccb-b0da-422f89f7d378", "22695074-2e4b-4757-a97e-7dcc049891d0", 6 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "96b3391f-5f7d-4813-8edb-80dfd8e8f11c", "f0080885-9e2f-446f-a100-936c17d27365", 6 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4", "40a3bd9e-7251-441a-b0f8-cba0174c2639", 8 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "9feac707-77eb-456b-a5e0-483c9fc65c96", "83e100d7-60de-403f-ba8d-f2c41e2b8008", 6 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941", "1ef58453-0f1e-451c-b26b-b7c981afd082", 8 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f", "aeed8e4a-e63a-45fa-8911-f9bd5a25fe5b", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersMoviesRatings_MovieId",
                table: "UsersMoviesRatings",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersMoviesRatings");

            migrationBuilder.CreateTable(
                name: "UsersMoviesVotes",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersMoviesVotes", x => new { x.ApplicationUserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_UsersMoviesVotes_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersMoviesVotes_Movies_MovieId",
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
                values: new object[] { "7ac72e8a-72cf-4f74-9cc3-b1af7f0bf96c", "AQAAAAEAACcQAAAAEP/BNbd9+UuXd8gdWmc7gPd/NxpQEvOpTWI/z6xmaM3yWES1HuGUHY4hUjQhHTiNkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af55837a-48d1-442b-b3c7-f85ea4254479", "AQAAAAEAACcQAAAAEHlDKRoBj94z+8N/A7fWmU7tCYW7Q3PZqtPTHEaoC2g+hPdODudpwBsNw+viDKJPPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a29d15a-69d4-431f-acfc-611e4a953970", "AQAAAAEAACcQAAAAEG/MmaeOQ98K6/GApDXWkGiRzy5kw9X6MEG4LIdG8iuCSN4aup/pYAPMUhjaUlh30g==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 1, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 31, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 7, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 11, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 4, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 5, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 6, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 12, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 2, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 3, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 13, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 8, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 30, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 10, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 54, 12, 411, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.InsertData(
                table: "UsersMoviesVotes",
                columns: new[] { "ApplicationUserId", "MovieId", "Id", "Rating" },
                values: new object[,]
                {
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "0f744962-21c0-4dcf-af3f-c3b91ddf321b", "0a799f60-91ef-4879-a8d6-84ccf8c4da43", 8 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "4abeaca8-0683-45ac-acc1-e628f78a9bc1", "7b7e828e-dad9-44ab-b3e9-38dfcf31aba1", 6 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "74d857da-6b3f-4d25-9b18-e0dbeff061a6", "324027ee-90f2-429a-9e72-b6c36a4c01e4", 3 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "81689a51-4cb2-483f-a3d6-da6107da4ed0", "0991b640-e9ee-4d81-9d72-ce9073e401ec", 6 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "9867b25f-69af-40ff-b5df-b461eb5232df", "d839acbc-ee94-4fb7-bda0-715fe5b5a901", 7 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "9c762863-ba47-4ab2-acbc-930a31fa2dfd", "7914edbe-b15c-4c9b-81ae-bf4a8f32f7c2", 7 },
                    { "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "a127a2e1-a4f9-46ac-a687-ea95d77074bb", "a104b0db-1547-4e75-8b94-9a6b879a1444", 7 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "4cbe3454-a451-418b-8ea0-f1f5fe540002", "8c77caa3-c1e4-4fad-86d3-68a1478cab10", 8 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "515ae48d-59c7-4abb-a15c-233c077139aa", "4e4ab8ea-93c8-4e0d-aa73-ce617f5d90a7", 7 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "947c6c71-4273-4ccb-b0da-422f89f7d378", "22695074-2e4b-4757-a97e-7dcc049891d0", 6 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "96b3391f-5f7d-4813-8edb-80dfd8e8f11c", "f0080885-9e2f-446f-a100-936c17d27365", 6 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4", "40a3bd9e-7251-441a-b0f8-cba0174c2639", 8 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "9feac707-77eb-456b-a5e0-483c9fc65c96", "83e100d7-60de-403f-ba8d-f2c41e2b8008", 6 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941", "1ef58453-0f1e-451c-b26b-b7c981afd082", 8 },
                    { "c769b464-2126-4249-9809-7b8aad21d7fa", "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f", "aeed8e4a-e63a-45fa-8911-f9bd5a25fe5b", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersMoviesVotes_MovieId",
                table: "UsersMoviesVotes",
                column: "MovieId");
        }
    }
}
