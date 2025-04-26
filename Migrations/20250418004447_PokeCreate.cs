using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonSemAPI.Migrations
{
    /// <inheritdoc />
    public partial class PokeCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokeDexEntries_Pokemon_PokemonID",
                table: "PokeDexEntries");

            migrationBuilder.DropIndex(
                name: "IX_PokeDexEntries_PokemonID",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "PokemonName",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "PokemonType",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "PokeHeightInMeters",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "PokeWeightInLbs",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "PokemonDescription",
                table: "PokeDexEntries");

            migrationBuilder.RenameColumn(
                name: "SPDEFBaseStat",
                table: "Pokemon",
                newName: "Speed");

            migrationBuilder.RenameColumn(
                name: "SPDBaseStat",
                table: "Pokemon",
                newName: "SpDefense");

            migrationBuilder.RenameColumn(
                name: "SPATKBaseStat",
                table: "Pokemon",
                newName: "SpAttack");

            migrationBuilder.RenameColumn(
                name: "NationalDexNumber",
                table: "Pokemon",
                newName: "SPDIV");

            migrationBuilder.RenameColumn(
                name: "HPBaseStat",
                table: "Pokemon",
                newName: "SPDEV");

            migrationBuilder.RenameColumn(
                name: "DEFBaseStat",
                table: "Pokemon",
                newName: "SPDEFIV");

            migrationBuilder.RenameColumn(
                name: "ATKBaseStat",
                table: "Pokemon",
                newName: "SPDEFEV");

            migrationBuilder.RenameColumn(
                name: "PokemonID",
                table: "PokeDexEntries",
                newName: "SPDEFBaseStat");

            migrationBuilder.AddColumn<int>(
                name: "ATKEV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ATKIV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Attack",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentHP",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEFEV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEFIV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HPEV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HPIV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PokemonDexID",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PokemonLevel",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SPATKEV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SPATKIV",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ATKBaseStat",
                table: "PokeDexEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEFBaseStat",
                table: "PokeDexEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HPBaseStat",
                table: "PokeDexEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PokemonIntID",
                table: "PokeDexEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SPATKBaseStat",
                table: "PokeDexEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SPDBaseStat",
                table: "PokeDexEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokemonDexID",
                table: "Pokemon",
                column: "PokemonDexID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokeDexEntries_PokemonDexID",
                table: "Pokemon",
                column: "PokemonDexID",
                principalTable: "PokeDexEntries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokeDexEntries_PokemonDexID",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_PokemonDexID",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "ATKEV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "ATKIV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Attack",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "CurrentHP",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "DEFEV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "DEFIV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "HPEV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "HPIV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "PokemonDexID",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "PokemonLevel",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "SPATKEV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "SPATKIV",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "ATKBaseStat",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "DEFBaseStat",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "HPBaseStat",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "PokemonIntID",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "SPATKBaseStat",
                table: "PokeDexEntries");

            migrationBuilder.DropColumn(
                name: "SPDBaseStat",
                table: "PokeDexEntries");

            migrationBuilder.RenameColumn(
                name: "Speed",
                table: "Pokemon",
                newName: "SPDEFBaseStat");

            migrationBuilder.RenameColumn(
                name: "SpDefense",
                table: "Pokemon",
                newName: "SPDBaseStat");

            migrationBuilder.RenameColumn(
                name: "SpAttack",
                table: "Pokemon",
                newName: "SPATKBaseStat");

            migrationBuilder.RenameColumn(
                name: "SPDIV",
                table: "Pokemon",
                newName: "NationalDexNumber");

            migrationBuilder.RenameColumn(
                name: "SPDEV",
                table: "Pokemon",
                newName: "HPBaseStat");

            migrationBuilder.RenameColumn(
                name: "SPDEFIV",
                table: "Pokemon",
                newName: "DEFBaseStat");

            migrationBuilder.RenameColumn(
                name: "SPDEFEV",
                table: "Pokemon",
                newName: "ATKBaseStat");

            migrationBuilder.RenameColumn(
                name: "SPDEFBaseStat",
                table: "PokeDexEntries",
                newName: "PokemonID");

            migrationBuilder.AddColumn<string>(
                name: "PokemonName",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PokemonType",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PokeHeightInMeters",
                table: "PokeDexEntries",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PokeWeightInLbs",
                table: "PokeDexEntries",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "PokemonDescription",
                table: "PokeDexEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokeDexEntries_PokemonID",
                table: "PokeDexEntries",
                column: "PokemonID");

            migrationBuilder.AddForeignKey(
                name: "FK_PokeDexEntries_Pokemon_PokemonID",
                table: "PokeDexEntries",
                column: "PokemonID",
                principalTable: "Pokemon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
