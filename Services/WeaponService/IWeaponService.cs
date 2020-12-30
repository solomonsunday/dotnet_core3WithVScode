using System.Threading.Tasks;
using netCore3.Dtos.Character;
using netCore3.Dtos.Weapon;
using netCore3.Models;

namespace netCore3.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}