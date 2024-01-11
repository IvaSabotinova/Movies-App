using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Common;
using MoviesWebApi.Data;
using MoviesWebApi.Data.Dto;

namespace MoviesWebApi.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genresRepo;
        private readonly IMapper mapper;

        public GenreService(
            IRepository<Genre> genresRepo,
            IMapper mapper)
        {
            this.genresRepo = genresRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<GenreDto>> GetAllGenres()
        {
            return await this.genresRepo.AllAsNoTracking()
                .OrderBy(x=>x.Name)
                .ProjectTo<GenreDto>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
