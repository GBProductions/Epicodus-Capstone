namespace OscarAPI.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Nominee { get; set; }
        public string Year { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }

        public bool Winner { get; set; }
        public string Notes { get; set; }

    }
}