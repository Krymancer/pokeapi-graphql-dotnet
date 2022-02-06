using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeAPIGQL.Migrations
{
    public partial class AddPokemonNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Pokemons");
        }
    }
}
