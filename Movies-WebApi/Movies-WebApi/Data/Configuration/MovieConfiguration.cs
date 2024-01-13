using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesWebApi.Data;
using System.Globalization;

namespace Movies_WebApi.Data.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(this.CreateMovies());
        }
        private List<Movie> CreateMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = "9cb5b0c8-3f8f-4c5f-93f8-11d787f2c3b4",
                    Title = "Killers of the Flower Moon",
                    Description = "When oil is discovered in 1920s Oklahoma under Osage Nation land, the Osage people are murdered one by one—until the FBI steps in to unravel the mystery.",
                    GenreId = "0a492052-f154-4fff-a2eb-3999d0387535",
                    Duration = 206,                   
                    ReleaseDate = DateTime.ParseExact("18-10-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/KillersOfTheFlowerMoon.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now,                            
                },
                new Movie()
                {
                    Id = "96b3391f-5f7d-4813-8edb-80dfd8e8f11c",
                    Title = "Freelance",
                    Description = "An ex-special forces operative takes a job to provide security for a journalist as she interviews a dictator, but a military coup breaks out in the middle of the interview, they are forced to escape into the jungle where they must survive.",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 108,                    
                    ReleaseDate = DateTime.ParseExact("05-10-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                   ImageUrl = "/images/db-images/Freelance.jpeg",                   
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now.AddDays(-1)
                },
                new Movie()
                {
                    Id = "515ae48d-59c7-4abb-a15c-233c077139aa",
                    Title = "Trolls Band Together",
                    Description = "When Branch's brother, Floyd, is kidnapped for his musical talents by a pair of nefarious pop-star villains, Branch and Poppy embark on a harrowing and emotional journey to reunite the other brothers and rescue Floyd from a fate even worse than pop-culture obscurity.",
                    GenreId = "380b3fe3-e7b5-46bf-8bfd-65bf99031043",
                    Duration = 92,                   
                    ReleaseDate = DateTime.ParseExact("12-10-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     ImageUrl = "/images/db-images/TrollsBandTogether.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                     CreatedOn = DateTime.Now.AddDays(-2)                    
                     
                },
                new Movie()
                {
                    Id = "c5bc33b7-1d32-4a5e-ad4b-12c7ad623941",
                    Title = "Leo",
                    Description = "Jaded 74-year-old lizard Leo has been stuck in the same Florida classroom for decades with his terrarium-mate turtle. When he learns he only has one year left to live, he plans to escape to experience life on the outside but instead gets caught up in the problems of his anxious students — including an impossibly mean substitute teacher.",
                    GenreId = "380b3fe3-e7b5-46bf-8bfd-65bf99031043",
                    Duration = 102, 
                    ReleaseDate = DateTime.ParseExact("17-11-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/Leo.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now.AddDays(-3)
                },
                new Movie()
                {
                    Id = "e7dd77fa-7fc1-4b55-8aa1-4b43bb73c19f",
                    Title = "Wonka",
                    Description = "Willy Wonka – chock-full of ideas and determined to change the world one delectable bite at a time – is proof that the best things in life begin with a dream, and if you’re lucky enough to meet Willy Wonka, anything is possible.",
                    GenreId = "e226393d-c715-4d6e-bd0b-0dca06108336",
                    Duration = 117,                    
                    ReleaseDate = DateTime.ParseExact("06-12-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/Wonka.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now.AddDays(-4)
                },
                new Movie()
                {
                    Id = "9feac707-77eb-456b-a5e0-483c9fc65c96",
                    Title = "The Dark Kingdom",
                    Description = "To save their Kingdom from an army of undead, a group of warriors must travel through the forbidden lands fighting the fearsome beasts that call The Dark Kingdom their home.",
                    GenreId = "02b16bb6-0164-4143-b6b8-5a470b5d9eb4",
                    Duration = 85,                    
                    ReleaseDate = DateTime.ParseExact("26-11-2018", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/TheDarkKingdom.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now.AddDays(-5)
                },
                new Movie()
                {
                    Id = "4cbe3454-a451-418b-8ea0-f1f5fe540002",
                    Title = "Oppenheimer",
                    Description = "The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.",
                    GenreId = "0a492052-f154-4fff-a2eb-3999d0387535",
                    Duration = 181,                    
                    ReleaseDate = DateTime.ParseExact("19-07-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/Oppenheimer.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now.AddDays(-6)
                },
                new Movie()
                {
                    Id = "947c6c71-4273-4ccb-b0da-422f89f7d378",
                    Title = "Shockwave: Countdown to Disaster",
                    Description = "A stolen seismic weapon is activated in Yemen. A hostage freed there tries in vain to warn against its global effect. It starts seismic activity at the Californian fault line where her daughter and ex are monitoring it. Can they stop it?",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 90,                    
                    ReleaseDate = DateTime.ParseExact("02-09-2017", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                   ImageUrl = "/images/db-images/Shockwave-CountdownToDisaster.jpeg",
                    ApplicationUserId = "b276b391-ab92-41f7-a4a6-f29e8525a3f5",
                    CreatedOn = DateTime.Now.AddDays(-7)
                },
                new Movie()
                {
                    Id = "81689a51-4cb2-483f-a3d6-da6107da4ed0",
                    Title = "A Man of Reason",
                    Description = "After 10 years of incarceration on behalf of his employer, all Su-hyuk wants is a normal life - one he hopes will include his former girlfriend, Min-seo, and their daughter, In-bi. But once you've penetrated the upper echelons of the underworld, normal can prove hard to come by. Sometime in the past decade, meanwhile, Su-hyuk's employer has adopted an air of legitimacy. These days, the old gang steal and murder in the name of urban development. And they want the reluctant Su-hyuk on board.",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 103,                   
                    ReleaseDate = DateTime.ParseExact("15-08-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/AManOfReason.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-8)
                },
                new Movie()
                {
                    Id = "74d857da-6b3f-4d25-9b18-e0dbeff061a6",
                    Title = "Robot Apocalypse",
                    Description = "An expert hacker is targeted by a sentient AI after she realizes the threat it poses, and she must try to stay off its radar long enough to stop it.",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 87,                 
                    ReleaseDate = DateTime.ParseExact("26-07-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/RobotApocalypse.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-9)
                },
                new Movie()
                {
                    Id = "9c762863-ba47-4ab2-acbc-930a31fa2dfd",
                    Title = "Wifelike",
                    Description = "A grieving detective in the near-future hunts down criminals who trade artificial humans on the black market. In the fight to end AI exploitation, an underground resistance attempts to infiltrate him by sabotaging the programming of the artificial human assigned as his companion to behave like his late wife. She begins to question her reality as memories of a past life begin to surface in a world where nothing is as it seems.",
                    GenreId = "f6ad08bd-4b20-4516-a874-8b74bc200c28",
                    Duration = 106,                   
                    ReleaseDate = DateTime.ParseExact("12-08-2022", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/Wifelike.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-10)
                },
                new Movie()
                {
                    Id = "9867b25f-69af-40ff-b5df-b461eb5232df",
                    Title = "Fast X",
                    Description = "Over many missions and against impossible odds, Dom Toretto and his family have outsmarted, out-nerved and outdriven every foe in their path. Now, they confront the most lethal opponent they've ever faced: A terrifying threat emerging from the shadows of the past who's fueled by blood revenge, and who is determined to shatter this family and destroy everything—and everyone—that Dom loves, forever.",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 172,                   
                    ReleaseDate = DateTime.ParseExact("17-05-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/FastX.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-11)
                },
                new Movie()
                {
                    Id = "0f744962-21c0-4dcf-af3f-c3b91ddf321b",
                    Title = "Five Nights at Freddy's",
                    Description = "Recently fired and desperate for work, a troubled young man named Mike agrees to take a position as a night security guard at an abandoned theme restaurant: Freddy Fazbear's Pizzeria. But he soon discovers that nothing at Freddy's is what it seems.",
                    GenreId = "f88d69a3-a968-4789-ab94-812d13fb5c76",
                    Duration = 110,                    
                    ReleaseDate = DateTime.ParseExact("25-10-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/FiveNightsArFreddy's.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-12)
                },
                new Movie()
                {
                    Id = "4abeaca8-0683-45ac-acc1-e628f78a9bc1",
                    Title = "Reign of Chaos",
                    Description = "When the world is gripped by a plague unleashed by the evil lord Chaos, and humans are turned into rabid creatures, mankind can only be saved by three young women, descendants of a Goddess, with the power to stop Chaos' evil.",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 77,                   
                    ReleaseDate = DateTime.ParseExact("12-04-2022", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/ReignOfChaos.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-13)
                },
                new Movie()
                {
                    Id = "a127a2e1-a4f9-46ac-a687-ea95d77074bb",
                    Title = "The Hunger Games: The Ballad of Songbirds & Snakes",
                    Description = "64 years before he becomes the tyrannical president of Panem, Coriolanus Snow sees a chance for a change in fortunes when he mentors Lucy Gray Baird, the female tribute from District 12.",
                    GenreId = "df4b7cce-f599-483f-acf6-7d2af941853f",
                    Duration = 157,                   
                    ReleaseDate = DateTime.ParseExact("15-11-2023", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ImageUrl = "/images/db-images/TheHungerGames-TheBalladOfSongbirds&Snakes.jpeg",
                    ApplicationUserId = "c769b464-2126-4249-9809-7b8aad21d7fa",
                    CreatedOn = DateTime.Now.AddDays(-14)
                }
            };


            return movies;
        }
    }
}
