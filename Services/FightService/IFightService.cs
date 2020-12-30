using System.Threading.Tasks;
using netCore3.Dtos.Fight;
using netCore3.Models;

namespace netCore3.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);

    }
}