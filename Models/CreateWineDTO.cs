namespace BodegaVinos.Models
{
    public class CreateWineDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Variety { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Region { get; set; } = string.Empty;
        public int Stock { get; set; }
    }
}
