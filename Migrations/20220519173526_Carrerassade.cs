using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROYECTO_AMAZON.Migrations
{
    public partial class Carrerassade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ape_particpante",
                table: "CARRERAs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ape_particpante",
                table: "CARRERAs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
