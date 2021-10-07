using Microsoft.EntityFrameworkCore.Migrations;

namespace OscarAPI.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nominations",
                columns: new[] { "NominationId", "Category", "CategoryActive", "Film", "Nominee", "Notes", "Winner", "Year" },
                values: new object[,]
                {
                    { 1, "Best Picture", "Yes", "Nomadland", "Frances McDormand, Peter Spears, Mollye Asher, Dan Janvey, Chloé Zhao", "N/A", "Yes", "2020" },
                    { 15, "Best Picture", "Yes", "The Departed", "Graham King", "N/A", "Yes", "2006" },
                    { 14, "Best Picture", "Yes", "No Country for Old Men", "Scott Rudin, Ethan Coen and Joel Coen", "N/A", "Yes", "2007" },
                    { 13, "Best Picture", "Yes", "Slumdog Millionaire", "Christian Colson", "N/A", "Yes", "2008" },
                    { 12, "Best Picture", "Yes", "The Hurt Locker", "Kathryn Bigelow, Mark Boal, Nicolas Chartier and Greg Shapiro", "N/A", "Yes", "2009" },
                    { 11, "Best Picture", "Yes", "The King's Speech", "Iain Canning, Emile Sherman and Gareth Unwin", "N/A", "Yes", "2010" },
                    { 10, "Best Picture", "Yes", "The Artist", "Thomas Langmann", "N/A", "Yes", "2011" },
                    { 16, "Best Picture", "Yes", "Crash", "Paul Haggis and Cathy Schulman", "N/A", "Yes", "2005" },
                    { 9, "Best Picture", "Yes", "Argo", "Grant Heslov, Ben Affleck and George Clooney", "N/A", "Yes", "2012" },
                    { 7, "Best Picture", "Yes", "Birdman or (The Unexpected Virtue of Ignorance)", "Alejandro G. Iñárritu, John Lesher and James W. Skotchdopole", "N/A", "Yes", "2014" },
                    { 6, "Best Picture", "Yes", "Spotlight", "Michael Sugar, Steve Golin, Nicole Rocklin and Blye Pagon Faust", "N/A", "Yes", "2015" },
                    { 5, "Best Picture", "Yes", "Moonlight", "Adele Romanski, Dede Gardner and Jeremy Kleiner", "N/A", "Yes", "2016" },
                    { 4, "Best Picture", "Yes", "The Shape of Water", "Guillermo del Toro and J. Miles Dale", "N/A", "Yes", "2017" },
                    { 3, "Best Picture", "Yes", "Green Book", "Jim Burke, Charles B. Wessler, Brian Currie, Peter Farrelly and Nick Vallelonga", "N/A", "Yes", "2018" },
                    { 2, "Best Picture", "Yes", "Parasite", "Kwak Sin Ae and Bong Joon Ho", "N/A", "Yes", "2019" },
                    { 8, "Best Picture", "Yes", "12 Years a Slave", "Brad Pitt, Dede Gardner, Jeremy Kleiner, Steve McQueen and Anthony Katagas", "N/A", "Yes", "2013" },
                    { 17, "Best Picture", "Yes", "Million Dollar Baby", "Clint Eastwood, Albert S. Ruddy and Tom Rosenberg", "N/A", "Yes", "2004" }
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
        }
    }
}
