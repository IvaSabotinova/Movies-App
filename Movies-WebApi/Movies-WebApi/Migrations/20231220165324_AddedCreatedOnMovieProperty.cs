using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class AddedCreatedOnMovieProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                column: "CreatedOn",
                value: new DateTime(2023, 12, 8, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 7, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 14, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 18, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 11, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 12, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 13, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 19, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 9, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 10, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 20, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 15, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 6, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 17, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 16, 18, 53, 24, 275, DateTimeKind.Local).AddTicks(8505));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d427bdb-ae64-45b7-97da-8f5aed7ec067", "AQAAAAEAACcQAAAAEPsj+Rnrp/alQcbBenqVfao+cWPUm765rJWhdlhGb+3ELvJKOvdm69FCL8WdqUT/KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42ab6774-eab7-47a7-9e48-32871c7daae8", "AQAAAAEAACcQAAAAEIx3jTbks9+UWPz6XeLT4GSvhoa2BFEnsEglgaJZ7JiE6giR8KBNHGo7w6Qv/8V4NQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "930b580a-727f-4bd6-91a3-f1c510e411b3", "AQAAAAEAACcQAAAAELf4okIkYsc6xaB/oZfccyctRJtMzhDukYPSpQtrkNE8fVXZNg1D5ZU7s4BPy6swZg==" });
        }
    }
}
