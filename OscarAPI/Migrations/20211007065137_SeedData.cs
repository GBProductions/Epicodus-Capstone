using Microsoft.EntityFrameworkCore.Migrations;

namespace OscarAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nominations",
                columns: new[] { "NominationId", "Category", "CategoryActive", "Film", "Nominee", "Notes", "Winner", "Year" },
                values: new object[,]
                {
                    { 1, "Best Picture", "Yes", "Nomadland", "Frances McDormand, Peter Spears, Mollye Asher, Dan Janvey, Chloé Zhao", "N/A", "Yes", "2020" },
                    { 68, "Best Motion Picture", "Yes", "On the Waterfront", "Sam Spiegel", "N/A", "Yes", "1954" },
                    { 67, "Best Motion Picture", "Yes", "Marty", "Harold Hecht", "N/A", "Yes", "1955" },
                    { 66, "Best Motion Picture", "Yes", "Around the World in 80 Days", "Michael Todd", "N/A", "Yes", "1956" },
                    { 65, "Best Motion Picture", "Yes", "The Bridge on the River Kwai", "Sam Spiegel", "N/A", "Yes", "1957" },
                    { 64, "Best Motion Picture", "Yes", "Gigi", "Arthur Freed", "N/A", "Yes", "1958" },
                    { 63, "Best Motion Picture", "Yes", "Ben-Hur", "Sam Zimbalist", "N/A", "Yes", "1959" },
                    { 62, "Best Motion Picture", "Yes", "The Apartment", "Billy Wilder", "N/A", "Yes", "1960" },
                    { 61, "Best Motion Picture", "Yes", "West Side Story", "Robert Wise", "N/A", "Yes", "1961" },
                    { 60, "Best Picture", "Yes", "Lawrence of Arabia", "Sam Spiegel", "N/A", "Yes", "1962" },
                    { 59, "Best Picture", "Yes", "Tom Jones", "Tony Richardson", "N/A", "Yes", "1963" },
                    { 58, "Best Picture", "Yes", "My Fair Lady", "Jack L. Warner", "N/A", "Yes", "1964" },
                    { 57, "Best Picture", "Yes", "The Sound of Music", "Robert Wise", "N/A", "Yes", "1965" },
                    { 56, "Best Picture", "Yes", "A Man for all Seasons", "Fred Zinnemann", "N/A", "Yes", "1966" },
                    { 55, "Best Picture", "Yes", "In the Heat of the Night", "Walter Mirisch", "N/A", "Yes", "1967" },
                    { 54, "Best Picture", "Yes", "Oliver!", "John Woolf", "N/A", "Yes", "1968" },
                    { 53, "Best Picture", "Yes", "Midnight Cowboy", "Jerome Hellman", "N/A", "Yes", "1969" },
                    { 52, "Best Picture", "Yes", "Patton", "Frank McCarthy", "N/A", "Yes", "1970" },
                    { 51, "Best Picture", "Yes", "The French Connection", "Philip D'Antoni", "N/A", "Yes", "1971" },
                    { 50, "Best Picture", "Yes", "The Godfather", "Albert S. Ruddy", "N/A", "Yes", "1972" },
                    { 69, "Best Motion Picture", "Yes", "From Here to Eternity", "Buddy Adler,", "N/A", "Yes", "1953" },
                    { 70, "Best Motion Picture", "Yes", "The Greatest Show on Earth", "Cecil B. DeMille", "N/A", "Yes", "1952" },
                    { 71, "Best Motion Picture", "Yes", "An American in Paris", "Arthur Freed", "N/A", "Yes", "1951" },
                    { 72, "Best Motion Picture", "Yes", "All About Eve", "20th Century-Fox ", "N/A", "Yes", "1950" },
                    { 94, "Outstanding Production", "Yes", "All Quiet on the Western Front", "Universal", "N/A", "Yes", "1929/1930" },
                    { 93, "Outstanding Production", "Yes", "Cimarron", "RKO Radio", "N/A", "Yes", "1930/1931" },
                    { 92, "Outstanding Production", "Yes", "Grand Hotel", "Metro-Goldwyn-Mayer", "N/A", "Yes", "1931/1932" },
                    { 91, "Outstanding Production", "Yes", "Cavalcade", "Fox", "N/A", "Yes", "1932/1933" },
                    { 90, "Outstanding Production", "Yes", "It Happened One Night", "Columbia", "N/A", "Yes", "1934" },
                    { 89, "Outstanding Production", "Yes", "Mutiny on the Bounty", "Metro-Goldwyn-Mayer", "N/A", "Yes", "1935" },
                    { 88, "Outstanding Production", "Yes", "The Great Ziegfeld", "Metro-Goldwyn-Mayer", "N/A", "Yes", "1936" },
                    { 87, "Outstanding Production", "Yes", "The Life of Emilie Zola", "Warner Bros.", "N/A", "Yes", "1937" },
                    { 86, "Outstanding Production", "Yes", "You Can't Take It With You", "Columbia", "N/A", "Yes", "1938" },
                    { 49, "Best Picture", "Yes", "The Sting", "Tony Bill, Michael Phillips and Julia Phillips", "N/A", "Yes", "1973" },
                    { 85, "Outstanding Production", "Yes", "Gone with the Wind", "Selznick International Pictures", "N/A", "Yes", "1939" },
                    { 81, "Outstanding Motion Picture", "Yes", "How Green Was My Valley", "20th Century-Fox ", "N/A", "Yes", "1941" },
                    { 80, "Outstanding Motion Picture", "Yes", "Mrs. Miniver", "Metro-Goldwyn-Mayer", "N/A", "Yes", "1942" },
                    { 79, "Outstanding Motion Picture", "Yes", "Casablanca", "Warner Bros.", "N/A", "Yes", "1943" },
                    { 78, "Best Motion Picture", "Yes", "Going My Way", "Paramount", "N/A", "Yes", "1944" },
                    { 77, "Best Motion Picture", "Yes", "The Lost Weekend", "Paramount", "N/A", "Yes", "1945" },
                    { 76, "Best Motion Picture", "Yes", "The Best Years of Our Lives", "Samuel Goldwyn Productions", "N/A", "Yes", "1946" },
                    { 75, "Best Motion Picture", "Yes", "Gentleman's Agreement", "20th Century-Fox ", "N/A", "Yes", "1947" },
                    { 74, "Best Motion Picture", "Yes", "Hamlet", "J. Arthur Rank-Two Cities Films", "N/A", "Yes", "1948" },
                    { 73, "Best Motion Picture", "Yes", "All The King's Men", "Robert Rossen Productions", "N/A", "Yes", "1949" },
                    { 84, "Outstanding Production", "Yes", "Rebecca", "Selznick International Pictures", "N/A", "Yes", "1940" },
                    { 48, "Best Picture", "Yes", "The Godfather Part II", "Francis Ford Coppola, Producer; Gray Frederickson and Fred Roos", "Listed as Co-Producers", "Yes", "1974" },
                    { 47, "Best Picture", "Yes", "One Flew over the Cuckoo's Nest", "Saul Zaentz and Michael Douglas", "N/A", "Yes", "1975" },
                    { 46, "Best Picture", "Yes", "Rocky", "Irwin Winkler and Robert Chartoff", "N/A", "Yes", "1976" },
                    { 21, "Best Picture", "Yes", "A Beautiful Mind", "Brian Grazer and Ron Howard", "N/A", "Yes", "2001" },
                    { 20, "Best Picture", "Yes", "Chicago", "Martin Richards", "N/A", "Yes", "2002" },
                    { 19, "Best Picture", "Yes", "The Lord of the Rings: The Return of the King", "Barrie M. Osborne, Peter Jackson and Fran Walsh", "N/A", "Yes", "2003" },
                    { 18, "Directing", "Yes", "Nomadland", "Chloé Zhao", "N/A", "Yes", "2020" },
                    { 17, "Best Picture", "Yes", "Million Dollar Baby", "Clint Eastwood, Albert S. Ruddy and Tom Rosenberg", "N/A", "Yes", "2004" },
                    { 16, "Best Picture", "Yes", "Crash", "Paul Haggis and Cathy Schulman", "N/A", "Yes", "2005" },
                    { 15, "Best Picture", "Yes", "The Departed", "Graham King", "N/A", "Yes", "2006" },
                    { 14, "Best Picture", "Yes", "No Country for Old Men", "Scott Rudin, Ethan Coen and Joel Coen", "N/A", "Yes", "2007" },
                    { 13, "Best Picture", "Yes", "Slumdog Millionaire", "Christian Colson", "N/A", "Yes", "2008" },
                    { 22, "Best Picture", "Yes", "Gladiator", "Douglas Wick, David Franzoni and Branko Lustig", "N/A", "Yes", "2000" },
                    { 12, "Best Picture", "Yes", "The Hurt Locker", "Kathryn Bigelow, Mark Boal, Nicolas Chartier and Greg Shapiro", "N/A", "Yes", "2009" },
                    { 10, "Best Picture", "Yes", "The Artist", "Thomas Langmann", "N/A", "Yes", "2011" },
                    { 9, "Best Picture", "Yes", "Argo", "Grant Heslov, Ben Affleck and George Clooney", "N/A", "Yes", "2012" },
                    { 8, "Best Picture", "Yes", "12 Years a Slave", "Brad Pitt, Dede Gardner, Jeremy Kleiner, Steve McQueen and Anthony Katagas", "N/A", "Yes", "2013" },
                    { 7, "Best Picture", "Yes", "Birdman or (The Unexpected Virtue of Ignorance)", "Alejandro G. Iñárritu, John Lesher and James W. Skotchdopole", "N/A", "Yes", "2014" },
                    { 6, "Best Picture", "Yes", "Spotlight", "Michael Sugar, Steve Golin, Nicole Rocklin and Blye Pagon Faust", "N/A", "Yes", "2015" },
                    { 5, "Best Picture", "Yes", "Moonlight", "Adele Romanski, Dede Gardner and Jeremy Kleiner", "N/A", "Yes", "2016" },
                    { 4, "Best Picture", "Yes", "The Shape of Water", "Guillermo del Toro and J. Miles Dale", "N/A", "Yes", "2017" },
                    { 3, "Best Picture", "Yes", "Green Book", "Jim Burke, Charles B. Wessler, Brian Currie, Peter Farrelly and Nick Vallelonga", "N/A", "Yes", "2018" },
                    { 2, "Best Picture", "Yes", "Parasite", "Kwak Sin Ae and Bong Joon Ho", "N/A", "Yes", "2019" },
                    { 11, "Best Picture", "Yes", "The King's Speech", "Iain Canning, Emile Sherman and Gareth Unwin", "N/A", "Yes", "2010" },
                    { 95, "Outstanding Production", "Yes", "The Broadway Melody", "Metro-Goldwyn-Mayer", "NOT AN OFFICIAL NOMINATION. There were no announcements of nominations, no certificates of nomination or honorable mention, and only the winners were revealed during the awards banquet on April 3, 1930.", "Yes", "1928/1929" },
                    { 23, "Best Picture", "Yes", "American Beauty", "Bruce Cohen and Dan Jinks", "N/A", "Yes", "1999" },
                    { 25, "Best Picture", "Yes", "Titanic", "James Cameron and Jon Landau", "N/A", "Yes", "1997" },
                    { 45, "Best Picture", "Yes", "Annie Hall", "Charles H. Joffe", "N/A", "Yes", "1977" },
                    { 44, "Best Picture", "Yes", "The Deer Hunter", "Barry Spikings, Michael Deeley, Michael Cimino and John Peverall", "N/A", "Yes", "1978" },
                    { 43, "Best Picture", "Yes", "Kramer vs. Kramer", "Stanley R. Jaffe", "N/A", "Yes", "1979" },
                    { 42, "Best Picture", "Yes", "Ordinary People", "Ronald L. Schwary", "N/A", "Yes", "1980" },
                    { 41, "Best Picture", "Yes", "Chariots of Fire", "David Puttnam", "N/A", "Yes", "1981" },
                    { 40, "Best Picture", "Yes", "Ghandi", "Richard Attenborough", "N/A", "Yes", "1982" },
                    { 39, "Best Picture", "Yes", "Terms of Endearment", "James L. Brooks", "N/A", "Yes", "1983" },
                    { 38, "Best Picture", "Yes", "Amadeus", "Saul Zaentz", "N/A", "Yes", "1984" },
                    { 37, "Best Picture", "Yes", "Out of Africa", "Sydney Pollack", "N/A", "Yes", "1985" },
                    { 24, "Best Picture", "Yes", "Shakespeare in Love", "David Parfitt, Donna Gigliotti, Harvey Weinstein, Edward Zwick and Marc Norman", "N/A", "Yes", "1998" },
                    { 36, "Best Picture", "Yes", "Platoon", "Arnold Kopelson", "N/A", "Yes", "1986" },
                    { 34, "Best Picture", "Yes", "Rain Man", "Mark Johnson", "N/A", "Yes", "1988" },
                    { 33, "Best Picture", "Yes", "Driving Miss Daisy", "Richard D. Zanuck and Lili Fini Zanuck", "N/A", "Yes", "1989" },
                    { 32, "Best Picture", "Yes", "Dances With Wolves", "Jim Wilson and Kevin Costner", "N/A", "Yes", "1990" },
                    { 31, "Best Picture", "Yes", "The Silence of the Lambs", "Edward Saxon, Kenneth Utt and Ron Bozman", "N/A", "Yes", "1991" },
                    { 30, "Best Picture", "Yes", "Unforgiven", "Clint Eastwood", "N/A", "Yes", "1992" },
                    { 29, "Best Picture", "Yes", "Schindler's List", "Steven Spielberg, Gerald R. Molen and Branko Lustig", "N/A", "Yes", "1993" },
                    { 28, "Best Picture", "Yes", "Forrest Gump", "Wendy Finerman, Steve Tisch and Steve Starkey", "N/A", "Yes", "1994" },
                    { 27, "Best Picture", "Yes", "Braveheart", "Mel Gibson, Alan Ladd, Jr. and Bruce Davey", "N/A", "Yes", "1995" },
                    { 26, "Best Picture", "Yes", "The English Patient", "Saul Zaentz", "N/A", "Yes", "1996" },
                    { 35, "Best Picture", "Yes", "The Last Emperor", "Jeremy Thomas", "N/A", "Yes", "1987" },
                    { 96, "Outstanding Picture", "Yes", "Wings", "Paramount Famous Lasky", "N/A", "Yes", "1927/1928" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Nominations",
                keyColumn: "NominationId",
                keyValue: 96);
        }
    }
}
