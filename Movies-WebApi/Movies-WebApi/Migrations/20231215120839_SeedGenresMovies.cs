using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_WebApi.Migrations
{
    public partial class SeedGenresMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "Movies",
                newName: "ImageUrl");

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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "01ac1390-aea0-4ffc-8275-bce17cd54072", "History" },
                    { "02b16bb6-0164-4143-b6b8-5a470b5d9eb4", "Fantasy" },
                    { "0a492052-f154-4fff-a2eb-3999d0387535", "Drama" },
                    { "10a30a24-7221-4585-b330-0c9efc16af35", "Adventure" },
                    { "380b3fe3-e7b5-46bf-8bfd-65bf99031043", "Animation" },
                    { "df4b7cce-f599-483f-acf6-7d2af941853f", "Action" },
                    { "e226393d-c715-4d6e-bd0b-0dca06108336", "Comedy" },
                    { "f6ad08bd-4b20-4516-a874-8b74bc200c28", "Thriller" },
                    { "f88d69a3-a968-4789-ab94-812d13fb5c76", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ApplicationUserId", "Description", "Duration", "GenreId", "ImageUrl", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { "0f744962-21c0-4dcf-af3f-c3b91ddf321b", "c769b464-2126-4249-9809-7b8aad21d7fa", "Recently fired and desperate for work, a troubled young man named Mike agrees to take a position as a night security guard at an abandoned theme restaurant: Freddy Fazbear's Pizzeria. But he soon discovers that nothing at Freddy's is what it seems.", 110, "f88d69a3-a968-4789-ab94-812d13fb5c76", "../../Photos/FiveNightsArFreddy's.jpeg", 0.0, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Five Nights at Freddy's" },
                    { "4abeaca8-0683-45ac-acc1-e628f78a9bc1", "c769b464-2126-4249-9809-7b8aad21d7fa", "When the world is gripped by a plague unleashed by the evil lord Chaos, and humans are turned into rabid creatures, mankind can only be saved by three young women, descendants of a Goddess, with the power to stop Chaos' evil.", 77, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/ReignOfChaos.jpeg", 0.0, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reign of Chaos" },
                    { "4cbe3454-a451-418b-8ea0-f1f5fe540002", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.", 181, "0a492052-f154-4fff-a2eb-3999d0387535", "../../Photos/Oppenheimer.jpeg", 0.0, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oppenheimer" },
                    { "515ae48d-59c7-4abb-a15c-233c077139aa", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "When Branch's brother, Floyd, is kidnapped for his musical talents by a pair of nefarious pop-star villains, Branch and Poppy embark on a harrowing and emotional journey to reunite the other brothers and rescue Floyd from a fate even worse than pop-culture obscurity.", 92, "380b3fe3-e7b5-46bf-8bfd-65bf99031043", "../../Photos/TrollsBandTogether.jpeg", 0.0, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trolls Band Together" },
                    { "74d857da-6b3f-4d25-9b18-e0dbeff061a6", "c769b464-2126-4249-9809-7b8aad21d7fa", "An expert hacker is targeted by a sentient AI after she realizes the threat it poses, and she must try to stay off its radar long enough to stop it.", 87, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/RobotApocalypse.jpeg", 0.0, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robot Apocalypse" },
                    { "81689a51-4cb2-483f-a3d6-da6107da4ed0", "c769b464-2126-4249-9809-7b8aad21d7fa", "After 10 years of incarceration on behalf of his employer, all Su-hyuk wants is a normal life - one he hopes will include his former girlfriend, Min-seo, and their daughter, In-bi. But once you've penetrated the upper echelons of the underworld, normal can prove hard to come by. Sometime in the past decade, meanwhile, Su-hyuk's employer has adopted an air of legitimacy. These days, the old gang steal and murder in the name of urban development. And they want the reluctant Su-hyuk on board.", 103, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/AManOfReason.jpeg", 0.0, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Man of Reason" },
                    { "947c6c71-4273-4ccb-b0da-422f89f7d378", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "A stolen seismic weapon is activated in Yemen. A hostage freed there tries in vain to warn against its global effect. It starts seismic activity at the Californian fault line where her daughter and ex are monitoring it. Can they stop it?", 90, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/Shockwave-CountdownToDisaster.jpeg", 0.0, new DateTime(2017, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shockwave: Countdown to Disaster" },
                    { "96b3391f-5f7d-4813-8edb-80dfd8e8f11c", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "An ex-special forces operative takes a job to provide security for a journalist as she interviews a dictator, but a military coup breaks out in the middle of the interview, they are forced to escape into the jungle where they must survive.", 108, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/Freelance.jpeg", 0.0, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freelance" },
                    { "9867b25f-69af-40ff-b5df-b461eb5232df", "c769b464-2126-4249-9809-7b8aad21d7fa", "Over many missions and against impossible odds, Dom Toretto and his family have outsmarted, out-nerved and outdriven every foe in their path. Now, they confront the most lethal opponent they've ever faced: A terrifying threat emerging from the shadows of the past who's fueled by blood revenge, and who is determined to shatter this family and destroy everything—and everyone—that Dom loves, forever.", 172, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/FastX.jpeg", 0.0, new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast X" },
                    { "9c762863-ba47-4ab2-acbc-930a31fa2dfd", "c769b464-2126-4249-9809-7b8aad21d7fa", "A grieving detective in the near-future hunts down criminals who trade artificial humans on the black market. In the fight to end AI exploitation, an underground resistance attempts to infiltrate him by sabotaging the programming of the artificial human assigned as his companion to behave like his late wife. She begins to question her reality as memories of a past life begin to surface in a world where nothing is as it seems.", 106, "f6ad08bd-4b20-4516-a874-8b74bc200c28", "../../Photos/Wifelike.jpeg", 0.0, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wifelike" },
                    { "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "When oil is discovered in 1920s Oklahoma under Osage Nation land, the Osage people are murdered one by one—until the FBI steps in to unravel the mystery.", 206, "0a492052-f154-4fff-a2eb-3999d0387535", "../../Photos/KillersOfTheFlowerMoon.jpeg", 0.0, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Killers of the Flower Moon" },
                    { "9feac707-77eb-456b-a5e0-483c9fc65c96", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "To save their Kingdom from an army of undead, a group of warriors must travel through the forbidden lands fighting the fearsome beasts that call The Dark Kingdom their home.", 85, "02b16bb6-0164-4143-b6b8-5a470b5d9eb4", "../../Photos/TheDarkKingdom.jpeg", 0.0, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Kingdom" },
                    { "a127a2e1-a4f9-46ac-a687-ea95d77074bb", "c769b464-2126-4249-9809-7b8aad21d7fa", "64 years before he becomes the tyrannical president of Panem, Coriolanus Snow sees a chance for a change in fortunes when he mentors Lucy Gray Baird, the female tribute from District 12.", 157, "df4b7cce-f599-483f-acf6-7d2af941853f", "../../Photos/TheHungerGames-TheBalladOfSongbirds&Snakes.jpeg", 0.0, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hunger Games: The Ballad of Songbirds & Snakes" },
                    { "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "Jaded 74-year-old lizard Leo has been stuck in the same Florida classroom for decades with his terrarium-mate turtle. When he learns he only has one year left to live, he plans to escape to experience life on the outside but instead gets caught up in the problems of his anxious students — including an impossibly mean substitute teacher.", 102, "380b3fe3-e7b5-46bf-8bfd-65bf99031043", "../../Photos/Leo.jpeg", 0.0, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo" },
                    { "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f", "b276b391-ab92-41f7-a4a6-f29e8525a3f5", "Willy Wonka – chock-full of ideas and determined to change the world one delectable bite at a time – is proof that the best things in life begin with a dream, and if you’re lucky enough to meet Willy Wonka, anything is possible.", 117, "e226393d-c715-4d6e-bd0b-0dca06108336", "../../Photos/Wonka.jpeg", 0.0, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonka" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "01ac1390-aea0-4ffc-8275-bce17cd54072");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "10a30a24-7221-4585-b330-0c9efc16af35");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "0f744962-21c0-4dcf-af3f-c3b91ddf321b");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4abeaca8-0683-45ac-acc1-e628f78a9bc1");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4cbe3454-a451-418b-8ea0-f1f5fe540002");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "515ae48d-59c7-4abb-a15c-233c077139aa");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "74d857da-6b3f-4d25-9b18-e0dbeff061a6");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "81689a51-4cb2-483f-a3d6-da6107da4ed0");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "947c6c71-4273-4ccb-b0da-422f89f7d378");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "96b3391f-5f7d-4813-8edb-80dfd8e8f11c");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9867b25f-69af-40ff-b5df-b461eb5232df");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9c762863-ba47-4ab2-acbc-930a31fa2dfd");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9feac707-77eb-456b-a5e0-483c9fc65c96");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a127a2e1-a4f9-46ac-a687-ea95d77074bb");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "02b16bb6-0164-4143-b6b8-5a470b5d9eb4");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "0a492052-f154-4fff-a2eb-3999d0387535");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "380b3fe3-e7b5-46bf-8bfd-65bf99031043");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "df4b7cce-f599-483f-acf6-7d2af941853f");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e226393d-c715-4d6e-bd0b-0dca06108336");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "f6ad08bd-4b20-4516-a874-8b74bc200c28");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "f88d69a3-a968-4789-ab94-812d13fb5c76");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movies",
                newName: "ImageMimeType");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Movies",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "501a91af-219d-4ff3-b3b8-ae606dbc828a", "AQAAAAEAACcQAAAAEFfGnR5Jd32c4YASGDZDEG8RB5TuBWlrjW1l+EHEZexQKVFzb5sUzCHyEd9RVlW2Jg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcf159fe-f974-4e71-b836-0cfdf3b537e9", "AQAAAAEAACcQAAAAEAH5FSP2/NHA8+uei89nw4P2TlPg+J2IbowYZKEqNr7d+rioHIJCzTFczJK0IB0YjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c769b464-2126-4249-9809-7b8aad21d7fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ff7264b-fb40-4d70-a3e4-b967b6323d2a", "AQAAAAEAACcQAAAAEBX7r9bkpNePhhnT2KsAALz/dYotd9NSt7HRYnfEbCclmbnM574Dhm9GLvbARVoBAQ==" });
        }
    }
}
