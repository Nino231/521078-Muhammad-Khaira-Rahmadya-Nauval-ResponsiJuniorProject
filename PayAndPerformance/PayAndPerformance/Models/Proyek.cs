namespace PayAndPerformance.Models
{
    public class Proyek
    {
        public int Id { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Client { get; set; } = string.Empty;
        public decimal Budget { get; set; }
    }
}
