using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonSemAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalDexNumber = table.Column<int>(type: "int", nullable: false),
                    PokemonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HPBaseStat = table.Column<int>(type: "int", nullable: false),
                    ATKBaseStat = table.Column<int>(type: "int", nullable: false),
                    DEFBaseStat = table.Column<int>(type: "int", nullable: false),
                    SPATKBaseStat = table.Column<int>(type: "int", nullable: false),
                    SPDEFBaseStat = table.Column<int>(type: "int", nullable: false),
                    SPDBaseStat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
