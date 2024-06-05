using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class CinemaProfile : Profile
{
    protected CinemaProfile()
    {
        CreateMap<CreateFilmeDto, Cinema>();
        CreateMap<Cinema, ReadFilmeDto>();
        CreateMap<UpdateFilmeDto, Cinema>();
    }
}