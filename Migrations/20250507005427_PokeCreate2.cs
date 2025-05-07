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
            migrationBuilder.DropColumn(
                name: "Attack",
                table: "PokeIndividual");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "PokeIndividual");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "PokeIndividual");

            migrationBuilder.DropColumn(
                name: "SpAttack",
                table: "PokeIndividual");

            migrationBuilder.DropColumn(
                name: "SpDefense",
                table: "PokeIndividual");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "PokeIndividual");

            migrationBuilder.CreateTable(
                name: "PokemonStats",
                columns: table => new
                {
                    CalcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    SpAttack = table.Column<int>(type: "int", nullable: false),
                    SpDefense = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    DexIdNationalDexNumber = table.Column<int>(type: "int", nullable: false),
                    IndvIdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonStats", x => x.CalcId);
                    table.ForeignKey(
                        name: "FK_PokemonStats_PokeDexEntries_DexIdNationalDexNumber",
                        column: x => x.DexIdNationalDexNumber,
                        principalTable: "PokeDexEntries",
                        principalColumn: "NationalDexNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonStats_PokeIndividual_IndvIdID",
                        column: x => x.IndvIdID,
                        principalTable: "PokeIndividual",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonStats_DexIdNationalDexNumber",
                table: "PokemonStats",
                column: "DexIdNationalDexNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonStats_IndvIdID",
                table: "PokemonStats",
                column: "IndvIdID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonStats");

            migrationBuilder.AddColumn<int>(
                name: "Attack",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpAttack",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpDefense",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "PokeIndividual",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
