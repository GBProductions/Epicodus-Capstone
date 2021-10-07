using Microsoft.EntityFrameworkCore;

namespace OscarAPI.Models
{
    public class OscarAPIContext : DbContext 
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Nomination>()
                .HasData(
                    new Nomination { NominationId = 1, Nominee = "Frances McDormand, Peter Spears, Mollye Asher, Dan Janvey, Chloé Zhao", Film = "Nomadland", Year = "2020", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A"},
                    new Nomination { NominationId = 2, Nominee = "Kwak Sin Ae and Bong Joon Ho", Film = "Parasite", Year = "2019", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 3, Nominee = "Jim Burke, Charles B. Wessler, Brian Currie, Peter Farrelly and Nick Vallelonga", Film = "Green Book", Year = "2018", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 4, Nominee = "Guillermo del Toro and J. Miles Dale", Film = "The Shape of Water", Year = "2017", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 5, Nominee = "Adele Romanski, Dede Gardner and Jeremy Kleiner", Film = "Moonlight", Year = "2016", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 6, Nominee = "Michael Sugar, Steve Golin, Nicole Rocklin and Blye Pagon Faust", Film = "Spotlight", Year = "2015", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 7, Nominee = "Alejandro G. Iñárritu, John Lesher and James W. Skotchdopole", Film = "Birdman or (The Unexpected Virtue of Ignorance)", Year = "2014", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 8, Nominee = "Brad Pitt, Dede Gardner, Jeremy Kleiner, Steve McQueen and Anthony Katagas", Film = "12 Years a Slave", Year = "2013", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 9, Nominee ="Grant Heslov, Ben Affleck and George Clooney", Film = "Argo", Year = "2012", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 10, Nominee = "Thomas Langmann", Film = "The Artist", Year = "2011", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 11, Nominee = "Iain Canning, Emile Sherman and Gareth Unwin", Film = "The King's Speech", Year = "2010", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId =  12, Nominee = "Kathryn Bigelow, Mark Boal, Nicolas Chartier and Greg Shapiro", Film = "The Hurt Locker", Year = "2009", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 13, Nominee = "Christian Colson", Film = "Slumdog Millionaire", Year = "2008", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId =  14, Nominee = "Scott Rudin, Ethan Coen and Joel Coen", Film = "No Country for Old Men", Year = "2007", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 15, Nominee = "Graham King", Film = "The Departed", Year = "2006", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 16, Nominee = "Paul Haggis and Cathy Schulman", Film = "Crash", Year = "2005", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId =  17, Nominee = "Clint Eastwood, Albert S. Ruddy and Tom Rosenberg", Film = "Million Dollar Baby" , Year = "2004", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" }
                );
        }
        public OscarAPIContext(DbContextOptions<OscarAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Nomination> Nominations { get; set; }
    }
    
}