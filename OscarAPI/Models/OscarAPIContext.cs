using Microsoft.EntityFrameworkCore;

namespace OscarAPI.Models
{
    public class OscarAPIContext : DbContext 
    {
        public OscarAPIContext(DbContextOptions<OscarAPIContext> options)
            : base(options)
            {
            }

            public DbSet<Nomination> Nominations { get; set; }
    }
    
}