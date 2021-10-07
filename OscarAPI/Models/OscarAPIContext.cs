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
                    new Nomination { NominationId = 9, Nominee = "Grant Heslov, Ben Affleck and George Clooney", Film = "Argo", Year = "2012", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 10, Nominee = "Thomas Langmann", Film = "The Artist", Year = "2011", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 11, Nominee = "Iain Canning, Emile Sherman and Gareth Unwin", Film = "The King's Speech", Year = "2010", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 12, Nominee = "Kathryn Bigelow, Mark Boal, Nicolas Chartier and Greg Shapiro", Film = "The Hurt Locker", Year = "2009", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 13, Nominee = "Christian Colson", Film = "Slumdog Millionaire", Year = "2008", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 14, Nominee = "Scott Rudin, Ethan Coen and Joel Coen", Film = "No Country for Old Men", Year = "2007", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 15, Nominee = "Graham King", Film = "The Departed", Year = "2006", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 16, Nominee = "Paul Haggis and Cathy Schulman", Film = "Crash", Year = "2005", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 17, Nominee = "Clint Eastwood, Albert S. Ruddy and Tom Rosenberg", Film = "Million Dollar Baby" , Year = "2004", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 18, Nominee = "Chloé Zhao", Film = "Nomadland", Year = "2020", Category = "Directing", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 19, Nominee = "Barrie M. Osborne, Peter Jackson and Fran Walsh", Film = "The Lord of the Rings: The Return of the King", Year = "2003", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 20, Nominee = "Martin Richards", Film = "Chicago", Year = "2002", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 21, Nominee = "Brian Grazer and Ron Howard", Film = "A Beautiful Mind", Year = "2001", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 22, Nominee = "Douglas Wick, David Franzoni and Branko Lustig", Film = "Gladiator", Year = "2000", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 23, Nominee = "Bruce Cohen and Dan Jinks", Film = "American Beauty", Year = "1999", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 24, Nominee = "David Parfitt, Donna Gigliotti, Harvey Weinstein, Edward Zwick and Marc Norman", Film = "Shakespeare in Love", Year = "1998", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 25, Nominee = "James Cameron and Jon Landau", Film = "Titanic", Year = "1997", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 26, Nominee = "Saul Zaentz", Film = "The English Patient", Year = "1996", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 27, Nominee = "Mel Gibson, Alan Ladd, Jr. and Bruce Davey", Film = "Braveheart", Year = "1995", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 28, Nominee = "Wendy Finerman, Steve Tisch and Steve Starkey", Film = "Forrest Gump", Year = "1994", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 29, Nominee = "Steven Spielberg, Gerald R. Molen and Branko Lustig", Film = "Schindler's List", Year = "1993", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 30, Nominee = "Clint Eastwood", Film = "Unforgiven", Year = "1992", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 31, Nominee = "Edward Saxon, Kenneth Utt and Ron Bozman", Film = "The Silence of the Lambs", Year = "1991", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 32, Nominee = "Jim Wilson and Kevin Costner", Film = "Dances With Wolves", Year = "1990", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 33, Nominee = "Richard D. Zanuck and Lili Fini Zanuck", Film = "Driving Miss Daisy", Year = "1989", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 34, Nominee = "Mark Johnson", Film = "Rain Man", Year = "1988", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 35, Nominee = "Jeremy Thomas", Film = "The Last Emperor", Year = "1987", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 36, Nominee = "Arnold Kopelson", Film = "Platoon", Year = "1986", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 37, Nominee = "Sydney Pollack", Film = "Out of Africa", Year = "1985", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 38, Nominee = "Saul Zaentz", Film = "Amadeus", Year = "1984", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 39, Nominee = "James L. Brooks", Film = "Terms of Endearment", Year = "1983", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 40, Nominee = "Richard Attenborough", Film = "Ghandi", Year = "1982", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 41, Nominee = "David Puttnam", Film = "Chariots of Fire", Year = "1981", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 42, Nominee = "Ronald L. Schwary", Film = "Ordinary People", Year = "1980", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 43, Nominee = "Stanley R. Jaffe", Film = "Kramer vs. Kramer", Year = "1979", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 44, Nominee = "Barry Spikings, Michael Deeley, Michael Cimino and John Peverall", Film = "The Deer Hunter", Year = "1978", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 45, Nominee = "Charles H. Joffe", Film = "Annie Hall", Year = "1977", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 46, Nominee = "Irwin Winkler and Robert Chartoff", Film = "Rocky", Year = "1976", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 47, Nominee = "Saul Zaentz and Michael Douglas", Film = "One Flew over the Cuckoo's Nest", Year = "1975", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 48, Nominee = "Francis Ford Coppola, Producer; Gray Frederickson and Fred Roos", Film = "The Godfather Part II", Year = "1974", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "Listed as Co-Producers" },
                    new Nomination { NominationId = 49, Nominee = "Tony Bill, Michael Phillips and Julia Phillips", Film = "The Sting", Year = "1973", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 50, Nominee = "Albert S. Ruddy", Film = "The Godfather", Year = "1972", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 51, Nominee = "Philip D'Antoni", Film = "The French Connection", Year = "1971", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 52, Nominee = "Frank McCarthy", Film = "Patton", Year = "1970", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 53, Nominee = "Jerome Hellman", Film = "Midnight Cowboy", Year = "1969", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 54, Nominee = "John Woolf", Film = "Oliver!", Year = "1968", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 55, Nominee = "Walter Mirisch", Film = "In the Heat of the Night", Year = "1967", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 56, Nominee = "Fred Zinnemann", Film = "A Man for all Seasons", Year = "1966", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 57, Nominee = "Robert Wise", Film = "The Sound of Music", Year = "1965", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 58, Nominee = "Jack L. Warner", Film = "My Fair Lady", Year = "1964", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 59, Nominee = "Tony Richardson", Film = "Tom Jones", Year = "1963", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 60, Nominee = "Sam Spiegel", Film = "Lawrence of Arabia", Year = "1962", Category = "Best Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 61, Nominee = "Robert Wise", Film = "West Side Story", Year = "1961", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 62, Nominee = "Billy Wilder", Film = "The Apartment", Year = "1960", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 63, Nominee = "Sam Zimbalist", Film = "Ben-Hur", Year = "1959", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 64, Nominee = "Arthur Freed", Film = "Gigi", Year = "1958", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 65, Nominee = "Sam Spiegel", Film = "The Bridge on the River Kwai", Year = "1957", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 66, Nominee = "Michael Todd", Film = "Around the World in 80 Days", Year = "1956", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 67, Nominee = "Harold Hecht", Film = "Marty", Year = "1955", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 68, Nominee = "Sam Spiegel", Film = "On the Waterfront", Year = "1954", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 69, Nominee = "Buddy Adler,", Film = "From Here to Eternity", Year = "1953", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 70, Nominee = "Cecil B. DeMille", Film = "The Greatest Show on Earth", Year = "1952", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 71, Nominee = "Arthur Freed", Film = "An American in Paris", Year = "1951", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 72, Nominee = "20th Century-Fox ", Film = "All About Eve", Year = "1950", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 73, Nominee = "Robert Rossen Productions", Film = "All The King's Men", Year = "1949", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 74, Nominee = "J. Arthur Rank-Two Cities Films", Film = "Hamlet", Year = "1948", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 75, Nominee = "20th Century-Fox ", Film = "Gentleman's Agreement", Year = "1947", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 76, Nominee = "Samuel Goldwyn Productions", Film = "The Best Years of Our Lives", Year = "1946", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 77, Nominee = "Paramount", Film = "The Lost Weekend", Year = "1945", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 78, Nominee = "Paramount", Film = "Going My Way", Year = "1944", Category = "Best Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 79, Nominee = "Warner Bros.", Film = "Casablanca", Year = "1943", Category = "Outstanding Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 80, Nominee = "Metro-Goldwyn-Mayer", Film = "Mrs. Miniver", Year = "1942", Category = "Outstanding Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 81, Nominee = "20th Century-Fox ", Film = "How Green Was My Valley", Year = "1941", Category = "Outstanding Motion Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 84, Nominee = "Selznick International Pictures", Film = "Rebecca", Year = "1940", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 85, Nominee = "Selznick International Pictures", Film = "Gone with the Wind", Year = "1939", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 86, Nominee = "Columbia", Film = "You Can't Take It With You", Year = "1938", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 87, Nominee = "Warner Bros.", Film = "The Life of Emilie Zola", Year = "1937", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 88, Nominee = "Metro-Goldwyn-Mayer", Film = "The Great Ziegfeld", Year = "1936", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 89, Nominee = "Metro-Goldwyn-Mayer", Film = "Mutiny on the Bounty", Year = "1935", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 90, Nominee = "Columbia", Film = "It Happened One Night", Year = "1934", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 91, Nominee = "Fox", Film = "Cavalcade", Year = "1932/1933", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 92, Nominee = "Metro-Goldwyn-Mayer", Film = "Grand Hotel", Year = "1931/1932", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 93, Nominee = "RKO Radio", Film = "Cimarron", Year = "1930/1931", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 94, Nominee = "Universal", Film = "All Quiet on the Western Front", Year = "1929/1930", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" },
                    new Nomination { NominationId = 95, Nominee = "Metro-Goldwyn-Mayer", Film = "The Broadway Melody", Year = "1928/1929", Category = "Outstanding Production", CategoryActive = "Yes", Winner = "Yes", Notes = "NOT AN OFFICIAL NOMINATION. There were no announcements of nominations, no certificates of nomination or honorable mention, and only the winners were revealed during the awards banquet on April 3, 1930." },
                    new Nomination { NominationId = 96, Nominee = "Paramount Famous Lasky", Film = "Wings", Year = "1927/1928", Category = "Outstanding Picture", CategoryActive = "Yes", Winner = "Yes", Notes = "N/A" }
                );
        }

        public OscarAPIContext(DbContextOptions<OscarAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Nomination> Nominations { get; set; }
    }
    
}