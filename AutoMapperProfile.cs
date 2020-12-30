using System.Linq;
using AutoMapper;
using netCore3.Dtos.Character;
using netCore3.Dtos.Skill;
using netCore3.Dtos.Weapon;
using netCore3.Models;

namespace netCore3
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
            .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));

            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}