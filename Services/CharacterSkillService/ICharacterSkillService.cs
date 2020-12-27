using System.Threading.Tasks;
using netCore3.Dtos.Character;
using netCore3.Dtos.CharacterSkillDto;
using netCore3.Models;

namespace netCore3.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddChareacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}