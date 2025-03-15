using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonSemAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPokeDexEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PokemonType",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PokeDexEntries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalDexNumber = table.Column<int>(type: "int", nullable: false),
                    PokemonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokeHeightInMeters = table.Column<float>(type: "real", nullable: false),
                    PokeWeightInLbs = table.Column<float>(type: "real", nullable: false),
                    PokemonDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeDexEntries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PokeDexEntries_Pokemon_PokemonID",
                        column: x => x.PokemonID,
                        principalTable: "Pokemon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokeDexEntries_PokemonID",
                table: "PokeDexEntries",
                column: "PokemonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "PokemonType",
                table: "Pokemon");
        }
    }
}
