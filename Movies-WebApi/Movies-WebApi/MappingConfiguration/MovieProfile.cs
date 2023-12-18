using AutoMapper;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace Movies_WebApi.MappingConfiguration
{
    public class MovieProfile: Profile
    {
        public MovieProfile()
        {
            this.CreateMap<MovieDto, Movie>();
               
        }
    }
}
