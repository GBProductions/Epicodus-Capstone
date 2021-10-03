using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OscarAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nominee = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Year = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Category = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Winner = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
