using AutoMapper;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.MappingConfiguration
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            this.CreateMap<Movie, MovieInListDto>()
                .ForMember(x => x.AverageRating, opt => opt
                .MapFrom(src => src.Ratings.Any() 
                ? (double)src.Ratings.Sum(x => x.Rating) / src.Ratings.Count 
                : 0));

            this.CreateMap<MovieDto, Movie>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(s => DateTime.Now));

            this.CreateMap<Movie, MovieDetailsDto>()
                .ForMember(x => x.AverageRating, opt => opt
                .MapFrom(src => src.Ratings.Any()
                ? (double)src.Ratings.Sum(x => x.Rating) / src.Ratings.Count
                : 0));

            this.CreateMap<Genre, GenreDto>();

            this.CreateMap<UserMovieRatingDto, UserMovieRating>();

            this.CreateMap<WatchListItemDto, WatchList>();

            this.CreateMap<Movie, WatchListMovieDetailsDto>()
                .ForMember(x => x.AverageRating, opt => opt
                .MapFrom(src => src.Ratings.Any()
                ? (double)src.Ratings.Sum(x => x.Rating) / src.Ratings.Count
                : 0));

        }
    }
}
