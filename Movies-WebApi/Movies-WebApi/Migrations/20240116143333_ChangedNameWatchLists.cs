using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class ChangedNameWatchLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_AspNetUsers_ApplicationUserId",
                table: "WatchList");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_Movies_MovieId",
                table: "WatchList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList");

            migrationBuilder.RenameTable(
                name: "WatchList",
                newName: "WatchLists");

            migrationBuilder.RenameIndex(
                name: "IX_WatchList_MovieId",
                table: "WatchLists",
                newName: "IX_WatchLists_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists",
                columns: new[] { "ApplicationUserId", "MovieId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ec258c6-745d-42bc-a0af-60f76b9fec69", "AQAAAAEAACcQAAAAEEN1VEJTfCEqpUJSjocmf64BBCVhec4Fad69l5jf0EhLXpW3h3PGcx3P7xBrN1T80A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c03a3112-c2d1-42f3-b5ea-6cdb0354aa0a", "AQAAAAEAACcQAAAAEIIP29wgL+uWS7Rt917MEC7Rff9X50IRMbh/JYlJgofodgyFdlRp4cdvURhowiTCvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d212280a-64e0-4f7c-b443-9d2ca3033506", "AQAAAAEAACcQAAAAEIjh8R4Tj84IfhaUkRXAoPRLYP/zz3oZcWgd1mjekr7vnK2j4abo/1zvPEtxY+iURg==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 4, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 3, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 10, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 14, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 7, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 8, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 15, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 5, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 6, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 16, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 11, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 2, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 13, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 12, 16, 33, 32, 798, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.AddForeignKey(
                name: "FK_WatchLists_AspNetUsers_ApplicationUserId",
                table: "WatchLists",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchLists_Movies_MovieId",
                table: "WatchLists",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchLists_AspNetUsers_ApplicationUserId",
                table: "WatchLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchLists_Movies_MovieId",
                table: "WatchLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists");

            migrationBuilder.RenameTable(
                name: "WatchLists",
                newName: "WatchList");

            migrationBuilder.RenameIndex(
                name: "IX_WatchLists_MovieId",
                table: "WatchList",
                newName: "IX_WatchList_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList",
                columns: new[] { "ApplicationUserId", "MovieId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_AspNetUsers_ApplicationUserId",
                table: "WatchList",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_Movies_MovieId",
                table: "WatchList",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
