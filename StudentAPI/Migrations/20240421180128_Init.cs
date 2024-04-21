using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coctails");

            migrationBuilder.CreateTable(
                name: "Coctails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idDrink = table.Column<string>(type: "TEXT", nullable: false),
                    strDrink = table.Column<string>(type: "TEXT", nullable: false),
                    strInstructions = table.Column<string>(type: "TEXT", nullable: false),
                    strIngredient1 = table.Column<string>(type: "TEXT", nullable: false),
                    strIngredient2 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient3 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient4 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient5 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient6 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient7 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient8 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient9 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient10 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient11 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient12 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient13 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient14 = table.Column<string>(type: "TEXT", nullable: true),
                    strIngredient15 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coctails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coctails");
        }
    }
}
