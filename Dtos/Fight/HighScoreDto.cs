namespace netCore3.Dtos.Fight
{
    public class HighScoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fight { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}