using System.Collections.Generic;
using netCore3.Dtos.Skill;
using netCore3.Dtos.Waepon;
using netCore3.Models;

namespace netCore3.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Fredo";
        public int Hitpoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.knight;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
    }

}