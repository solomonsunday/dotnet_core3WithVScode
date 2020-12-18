using System.Collections.Generic;
using System.Threading.Tasks;
using netCore3.Dtos.Character;
using netCore3.Models;

namespace netCore3.Services.CharacterServices
{
    public interface ICharacterService

    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharcters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}