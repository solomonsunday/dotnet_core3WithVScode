namespace netCore3.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Fredo";
        public int Hitpoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.knight;
    }
}