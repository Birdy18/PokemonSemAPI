using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonSemAPI.Migrations
{
    /// <inheritdoc />
    public partial class PokeCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "Pokemon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon");

            migrationBuilder.RenameTable(
                name: "Pokemon",
                newName: "PokeIndividual");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                newName: "IX_PokeIndividual_PokemonDexNationalDexNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokeIndividual",
                table: "PokeIndividual",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                column: "PokemonDexNationalDexNumber",
                principalTable: "PokeDexEntries",
                principalColumn: "NationalDexNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "PokeIndividual");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokeIndividual",
                table: "PokeIndividual");

            migrationBuilder.RenameTable(
                name: "PokeIndividual",
                newName: "Pokemon");

            migrationBuilder.RenameIndex(
                name: "IX_PokeIndividual_PokemonDexNationalDexNumber",
                table: "Pokemon",
                newName: "IX_Pokemon_PokemonDexNationalDexNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "Pokemon",
                column: "PokemonDexNationalDexNumber",
                principalTable: "PokeDexEntries",
                principalColumn: "NationalDexNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
