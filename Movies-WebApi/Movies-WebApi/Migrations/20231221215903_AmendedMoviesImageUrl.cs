using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class AmendedMoviesImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f7d4fee-d2fc-4ebc-af23-7165f9a477b5", "AQAAAAEAACcQAAAAEE8+Orf/QxtyHTWSlKARdmboQ63vEi1S02hHWTdQUnmgCKkXTCtC1xld5aqkjHBwow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d6a7ecf-22c3-48b1-a999-9a8626fb68cc", "AQAAAAEAACcQAAAAEMG4i1ZUBCFsoIVIeQbDLgmJ2jTCi7Yw3Bf7aOe7z9j0m1DU1nc+U6AdB/hzV9h4vQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9b31d7e-f24a-40b8-ae4f-a04f326e8eed", "AQAAAAEAACcQAAAAEJtGO2qYwwcGWyS5sNezihVyUXaimFF/xiXE4PtAvLbrkknaOzkJonHvAocd22xWOQ==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 9, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8072), "/images/db-images/FiveNightsArFreddy's.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 8, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8092), "/images/db-images/ReignOfChaos.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 15, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8012), "/images/db-images/Oppenheimer.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(7970), "/images/db-images/TrollsBandTogether.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 12, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8041), "/images/db-images/RobotApocalypse.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 13, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8030), "/images/db-images/AManOfReason.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8021), "/images/db-images/Shockwave-CountdownToDisaster.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(7960), "/images/db-images/Freelance.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8061), "/images/db-images/FastX.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 11, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8051), "/images/db-images/Wifelike.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 21, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(7911), "/images/db-images/KillersOfTheFlowerMoon.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8003), "/images/db-images/TheDarkKingdom.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 7, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(8102), "/images/db-images/TheHungerGames-TheBalladOfSongbirds&Snakes.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 18, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(7980), "/images/db-images/Leo.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 17, 23, 59, 3, 20, DateTimeKind.Local).AddTicks(7992), "/images/db-images/Wonka.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d01a37a4-286c-4dff-b9a7-401dc66118f8", "AQAAAAEAACcQAAAAEPkdxN9xob0NbfQtnMg4fITU3dfKqJi+bmVxMsJeVD+pjxUE05HfJSG/EAV70i1CBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab826cfd-f4f4-41dd-bc4f-26d7241b8fd9", "AQAAAAEAACcQAAAAENanBGV7W5FPQUlQWjjYsPP30Yf03fTVOErdicAUvfPVhWnOieq+M19MjIoq0poAfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16d809ab-4bb4-4c90-8e8b-c5e901d839e0", "AQAAAAEAACcQAAAAEAVfU9tP6cPsaEdOZRQ+q/qEFzfdlcdQRUe5UK96Nln8lUFSGXsjeDOe6TCECKVs0A==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 8, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8589), "../../Photos/FiveNightsArFreddy's.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 7, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8610), "../../Photos/ReignOfChaos.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8526), "../../Photos/Oppenheimer.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 18, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8486), "../../Photos/TrollsBandTogether.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8558), "../../Photos/RobotApocalypse.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 12, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8547), "../../Photos/AManOfReason.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 13, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8536), "../../Photos/Shockwave-CountdownToDisaster.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 19, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8475), "../../Photos/Freelance.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 9, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8580), "../../Photos/FastX.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 10, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8568), "../../Photos/Wifelike.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 20, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8423), "../../Photos/KillersOfTheFlowerMoon.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8516), "../../Photos/TheDarkKingdom.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8620), "../../Photos/TheHungerGames-TheBalladOfSongbirds&Snakes.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8495), "../../Photos/Leo.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2023, 12, 16, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8505), "../../Photos/Wonka.jpeg" });
        }
    }
}
