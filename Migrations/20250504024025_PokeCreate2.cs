using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonSemAPI.Migrations
{
    /// <inheritdoc />
    public partial class PokeCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "PokeIndividual");

            migrationBuilder.AlterColumn<int>(
                name: "PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BuildName",
                table: "PokeIndividual",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                column: "PokemonDexNationalDexNumber",
                principalTable: "PokeDexEntries",
                principalColumn: "NationalDexNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "PokeIndividual");

            migrationBuilder.AlterColumn<int>(
                name: "PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BuildName",
                table: "PokeIndividual",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                column: "PokemonDexNationalDexNumber",
                principalTable: "PokeDexEntries",
                principalColumn: "NationalDexNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
