using AutoMapper;
using ConsoleApp.DADOS;
using ConsoleApp.Models;


namespace DesafioSevenDaysOfCode.Perfil
{
    internal class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<PokemonDTO, Pokemon>();
        }
    }
}
