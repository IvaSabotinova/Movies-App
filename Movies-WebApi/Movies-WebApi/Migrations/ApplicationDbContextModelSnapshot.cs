﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesWebApi.Data;

#nullable disable

namespace Movies_WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "852e2785-b4e5-4aaf-a1cb-ead009d712e9",
                            ConcurrencyStamp = "9714cc66-6d8c-4597-8539-c800bfe8e463",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "f9f55e41-022f-47ba-9167-6f301eb2ab07",
                            ConcurrencyStamp = "4279b556-7973-4977-994e-a358fe7971e2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                            RoleId = "852e2785-b4e5-4aaf-a1cb-ead009d712e9"
                        },
                        new
                        {
                            UserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            RoleId = "f9f55e41-022f-47ba-9167-6f301eb2ab07"
                        },
                        new
                        {
                            UserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            RoleId = "f9f55e41-022f-47ba-9167-6f301eb2ab07"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MoviesWebApi.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "595fdbef-2f26-4d9e-8b59-07a46309ac7c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3d427bdb-ae64-45b7-97da-8f5aed7ec067",
                            Email = "admin@abv.bg",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ABV.BG",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPsj+Rnrp/alQcbBenqVfao+cWPUm765rJWhdlhGb+3ELvJKOvdm69FCL8WdqUT/KQ==",
                            PhoneNumber = "+359889694030",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72961cc8-9558-4700-8a36-19adf9e1f5c0",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "42ab6774-eab7-47a7-9e48-32871c7daae8",
                            Email = "george@abv.bg",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "GEORGE@ABV.BG",
                            NormalizedUserName = "GEORGE",
                            PasswordHash = "AQAAAAEAACcQAAAAEIx3jTbks9+UWPz6XeLT4GSvhoa2BFEnsEglgaJZ7JiE6giR8KBNHGo7w6Qv/8V4NQ==",
                            PhoneNumber = "+359888111111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5cf80d8c-a6a5-4594-84a3-7b5828c21191",
                            TwoFactorEnabled = false,
                            UserName = "George"
                        },
                        new
                        {
                            Id = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "930b580a-727f-4bd6-91a3-f1c510e411b3",
                            Email = "katya@abv.bg",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "KATYA@ABV.BG",
                            NormalizedUserName = "KATYA",
                            PasswordHash = "AQAAAAEAACcQAAAAELf4okIkYsc6xaB/oZfccyctRJtMzhDukYPSpQtrkNE8fVXZNg1D5ZU7s4BPy6swZg==",
                            PhoneNumber = "+359888222222",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "42e02d95-161f-4676-a5e1-410b07c0e3d0",
                            TwoFactorEnabled = false,
                            UserName = "Katya"
                        });
                });

            modelBuilder.Entity("MoviesWebApi.Data.Genre", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Genres", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0a492052-f154-4fff-a2eb-3999d0387535",
                            Name = "Drama"
                        },
                        new
                        {
                            Id = "01ac1390-aea0-4ffc-8275-bce17cd54072",
                            Name = "History"
                        },
                        new
                        {
                            Id = "02b16bb6-0164-4143-b6b8-5a470b5d9eb4",
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            Name = "Action"
                        },
                        new
                        {
                            Id = "e226393d-c715-4d6e-bd0b-0dca06108336",
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = "380b3fe3-e7b5-46bf-8bfd-65bf99031043",
                            Name = "Animation"
                        },
                        new
                        {
                            Id = "10a30a24-7221-4585-b330-0c9efc16af35",
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = "f88d69a3-a968-4789-ab94-812d13fb5c76",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = "f6ad08bd-4b20-4516-a874-8b74bc200c28",
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("MoviesWebApi.Data.Movie", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "When oil is discovered in 1920s Oklahoma under Osage Nation land, the Osage people are murdered one by one—until the FBI steps in to unravel the mystery.",
                            Duration = 206,
                            GenreId = "0a492052-f154-4fff-a2eb-3999d0387535",
                            ImageUrl = "../../Photos/KillersOfTheFlowerMoon.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Killers of the Flower Moon"
                        },
                        new
                        {
                            Id = "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "An ex-special forces operative takes a job to provide security for a journalist as she interviews a dictator, but a military coup breaks out in the middle of the interview, they are forced to escape into the jungle where they must survive.",
                            Duration = 108,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/Freelance.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Freelance"
                        },
                        new
                        {
                            Id = "515ae48d-59c7-4abb-a15c-233c077139aa",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "When Branch's brother, Floyd, is kidnapped for his musical talents by a pair of nefarious pop-star villains, Branch and Poppy embark on a harrowing and emotional journey to reunite the other brothers and rescue Floyd from a fate even worse than pop-culture obscurity.",
                            Duration = 92,
                            GenreId = "380b3fe3-e7b5-46bf-8bfd-65bf99031043",
                            ImageUrl = "../../Photos/TrollsBandTogether.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Trolls Band Together"
                        },
                        new
                        {
                            Id = "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "Jaded 74-year-old lizard Leo has been stuck in the same Florida classroom for decades with his terrarium-mate turtle. When he learns he only has one year left to live, he plans to escape to experience life on the outside but instead gets caught up in the problems of his anxious students — including an impossibly mean substitute teacher.",
                            Duration = 102,
                            GenreId = "380b3fe3-e7b5-46bf-8bfd-65bf99031043",
                            ImageUrl = "../../Photos/Leo.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Leo"
                        },
                        new
                        {
                            Id = "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "Willy Wonka – chock-full of ideas and determined to change the world one delectable bite at a time – is proof that the best things in life begin with a dream, and if you’re lucky enough to meet Willy Wonka, anything is possible.",
                            Duration = 117,
                            GenreId = "e226393d-c715-4d6e-bd0b-0dca06108336",
                            ImageUrl = "../../Photos/Wonka.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Wonka"
                        },
                        new
                        {
                            Id = "9feac707-77eb-456b-a5e0-483c9fc65c96",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "To save their Kingdom from an army of undead, a group of warriors must travel through the forbidden lands fighting the fearsome beasts that call The Dark Kingdom their home.",
                            Duration = 85,
                            GenreId = "02b16bb6-0164-4143-b6b8-5a470b5d9eb4",
                            ImageUrl = "../../Photos/TheDarkKingdom.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dark Kingdom"
                        },
                        new
                        {
                            Id = "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.",
                            Duration = 181,
                            GenreId = "0a492052-f154-4fff-a2eb-3999d0387535",
                            ImageUrl = "../../Photos/Oppenheimer.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Oppenheimer"
                        },
                        new
                        {
                            Id = "947c6c71-4273-4ccb-b0da-422f89f7d378",
                            ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                            Description = "A stolen seismic weapon is activated in Yemen. A hostage freed there tries in vain to warn against its global effect. It starts seismic activity at the Californian fault line where her daughter and ex are monitoring it. Can they stop it?",
                            Duration = 90,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/Shockwave-CountdownToDisaster.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2017, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Shockwave: Countdown to Disaster"
                        },
                        new
                        {
                            Id = "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "After 10 years of incarceration on behalf of his employer, all Su-hyuk wants is a normal life - one he hopes will include his former girlfriend, Min-seo, and their daughter, In-bi. But once you've penetrated the upper echelons of the underworld, normal can prove hard to come by. Sometime in the past decade, meanwhile, Su-hyuk's employer has adopted an air of legitimacy. These days, the old gang steal and murder in the name of urban development. And they want the reluctant Su-hyuk on board.",
                            Duration = 103,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/AManOfReason.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "A Man of Reason"
                        },
                        new
                        {
                            Id = "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "An expert hacker is targeted by a sentient AI after she realizes the threat it poses, and she must try to stay off its radar long enough to stop it.",
                            Duration = 87,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/RobotApocalypse.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Robot Apocalypse"
                        },
                        new
                        {
                            Id = "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "A grieving detective in the near-future hunts down criminals who trade artificial humans on the black market. In the fight to end AI exploitation, an underground resistance attempts to infiltrate him by sabotaging the programming of the artificial human assigned as his companion to behave like his late wife. She begins to question her reality as memories of a past life begin to surface in a world where nothing is as it seems.",
                            Duration = 106,
                            GenreId = "f6ad08bd-4b20-4516-a874-8b74bc200c28",
                            ImageUrl = "../../Photos/Wifelike.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Wifelike"
                        },
                        new
                        {
                            Id = "9867b25f-69af-40ff-b5df-b461eb5232df",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "Over many missions and against impossible odds, Dom Toretto and his family have outsmarted, out-nerved and outdriven every foe in their path. Now, they confront the most lethal opponent they've ever faced: A terrifying threat emerging from the shadows of the past who's fueled by blood revenge, and who is determined to shatter this family and destroy everything—and everyone—that Dom loves, forever.",
                            Duration = 172,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/FastX.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fast X"
                        },
                        new
                        {
                            Id = "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "Recently fired and desperate for work, a troubled young man named Mike agrees to take a position as a night security guard at an abandoned theme restaurant: Freddy Fazbear's Pizzeria. But he soon discovers that nothing at Freddy's is what it seems.",
                            Duration = 110,
                            GenreId = "f88d69a3-a968-4789-ab94-812d13fb5c76",
                            ImageUrl = "../../Photos/FiveNightsArFreddy's.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Five Nights at Freddy's"
                        },
                        new
                        {
                            Id = "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "When the world is gripped by a plague unleashed by the evil lord Chaos, and humans are turned into rabid creatures, mankind can only be saved by three young women, descendants of a Goddess, with the power to stop Chaos' evil.",
                            Duration = 77,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/ReignOfChaos.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Reign of Chaos"
                        },
                        new
                        {
                            Id = "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                            ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                            Description = "64 years before he becomes the tyrannical president of Panem, Coriolanus Snow sees a chance for a change in fortunes when he mentors Lucy Gray Baird, the female tribute from District 12.",
                            Duration = 157,
                            GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                            ImageUrl = "../../Photos/TheHungerGames-TheBalladOfSongbirds&Snakes.jpeg",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hunger Games: The Ballad of Songbirds & Snakes"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MoviesWebApi.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MoviesWebApi.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesWebApi.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MoviesWebApi.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesWebApi.Data.Movie", b =>
                {
                    b.HasOne("MoviesWebApi.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Movies")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesWebApi.Data.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MoviesWebApi.Data.ApplicationUser", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MoviesWebApi.Data.Genre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
