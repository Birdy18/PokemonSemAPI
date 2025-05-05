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
            migrationBuilder.CreateTable(
                name: "PokeDexEntries",
                columns: table => new
                {
                    NationalDexNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HPBaseStat = table.Column<int>(type: "int", nullable: false),
                    ATKBaseStat = table.Column<int>(type: "int", nullable: false),
                    DEFBaseStat = table.Column<int>(type: "int", nullable: false),
                    SPATKBaseStat = table.Column<int>(type: "int", nullable: false),
                    SPDEFBaseStat = table.Column<int>(type: "int", nullable: false),
                    SPDBaseStat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeDexEntries", x => x.NationalDexNumber);
                });

            migrationBuilder.CreateTable(
                name: "PokeIndividual",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonLevel = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    SpAttack = table.Column<int>(type: "int", nullable: false),
                    SpDefense = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    HPIV = table.Column<int>(type: "int", nullable: false),
                    ATKIV = table.Column<int>(type: "int", nullable: false),
                    DEFIV = table.Column<int>(type: "int", nullable: false),
                    SPATKIV = table.Column<int>(type: "int", nullable: false),
                    SPDEFIV = table.Column<int>(type: "int", nullable: false),
                    SPDIV = table.Column<int>(type: "int", nullable: false),
                    HPEV = table.Column<int>(type: "int", nullable: false),
                    ATKEV = table.Column<int>(type: "int", nullable: false),
                    DEFEV = table.Column<int>(type: "int", nullable: false),
                    SPATKEV = table.Column<int>(type: "int", nullable: false),
                    SPDEFEV = table.Column<int>(type: "int", nullable: false),
                    SPDEV = table.Column<int>(type: "int", nullable: false),
                    PokemonDexNationalDexNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeIndividual", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PokeIndividual_PokeDexEntries_PokemonDexNationalDexNumber",
                        column: x => x.PokemonDexNationalDexNumber,
                        principalTable: "PokeDexEntries",
                        principalColumn: "NationalDexNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokeIndividual_PokemonDexNationalDexNumber",
                table: "PokeIndividual",
                column: "PokemonDexNationalDexNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokeIndividual");

            migrationBuilder.DropTable(
                name: "PokeDexEntries");
        }
    }
}
