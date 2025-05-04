using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonSemAPI.Migrations
{
    /// <inheritdoc />
    public partial class PokeCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "PokeIndividual",
                newName: "BuildName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuildName",
                table: "PokeIndividual",
                newName: "Nickname");
        }
    }
}
