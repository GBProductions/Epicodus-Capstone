namespace OscarAPI.Models
{
    public class Nomination
    {
        public int NominationId { get; set; }
        public string Nominee { get; set; }
        public string Film { get; set; }
        public string Year { get; set; }
        public string Category { get; set; }
        public string Winner { get; set; }
        public string Notes { get; set; }

    }
}