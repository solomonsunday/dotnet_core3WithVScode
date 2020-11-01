using AutoMapper;
using netCore3.Dtos.Character;
using netCore3.Models;

namespace netCore3
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}