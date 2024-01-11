using AutoMapper;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.MappingConfiguration
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            this.CreateMap<Movie, MovieInListDto>();

            this.CreateMap<MovieDto, Movie>()
                .ForMember(x => x.CreatedOn, opt => opt.MapFrom(s => DateTime.Now));

            this.CreateMap<Movie, MovieDetailsDto>();

            this.CreateMap<Genre, GenreDto>();
        }
    }
}
