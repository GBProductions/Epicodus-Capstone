using System.ComponentModel.DataAnnotations;

namespace OscarAPI.Models
{
    public class Nomination
    {
        public int NominationId { get; set; }
        [Required]
        public string Nominee { get; set; }
        [Required]
        public string Film { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string CategoryActive { get; set; }
        [Required]
        public string Winner { get; set; }
        public string Notes { get; set; }

    }
}