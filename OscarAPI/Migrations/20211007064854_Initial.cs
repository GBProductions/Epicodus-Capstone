using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OscarAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nominations",
                columns: table => new
                {
                    NominationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nominee = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Film = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Year = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Category = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    CategoryActive = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Winner = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Notes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominations", x => x.NominationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nominations");
        }
    }
}
