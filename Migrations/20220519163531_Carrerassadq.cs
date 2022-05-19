using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROYECTO_AMAZON.Migrations
{
    public partial class Carrerassadq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CARRERAs_ALUMNOs_ape_particpanteid",
                table: "CARRERAs");

            migrationBuilder.DropForeignKey(
                name: "FK_CARRERAs_ALUMNOs_nombre_particpanteid",
                table: "CARRERAs");

            migrationBuilder.DropIndex(
                name: "IX_CARRERAs_ape_particpanteid",
                table: "CARRERAs");

            migrationBuilder.DropIndex(
                name: "IX_CARRERAs_nombre_particpanteid",
                table: "CARRERAs");

            migrationBuilder.DropColumn(
                name: "ape_particpanteid",
                table: "CARRERAs");

            migrationBuilder.DropColumn(
                name: "nombre_particpanteid",
                table: "CARRERAs");

            migrationBuilder.AddColumn<string>(
                name: "ape_particpante",
                table: "CARRERAs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nombre_particpante",
                table: "CARRERAs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ape_particpante",
                table: "CARRERAs");

            migrationBuilder.DropColumn(
                name: "nombre_particpante",
                table: "CARRERAs");

            migrationBuilder.AddColumn<int>(
                name: "ape_particpanteid",
                table: "CARRERAs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "nombre_particpanteid",
                table: "CARRERAs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CARRERAs_ape_particpanteid",
                table: "CARRERAs",
                column: "ape_particpanteid");

            migrationBuilder.CreateIndex(
                name: "IX_CARRERAs_nombre_particpanteid",
                table: "CARRERAs",
                column: "nombre_particpanteid");

            migrationBuilder.AddForeignKey(
                name: "FK_CARRERAs_ALUMNOs_ape_particpanteid",
                table: "CARRERAs",
                column: "ape_particpanteid",
                principalTable: "ALUMNOs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CARRERAs_ALUMNOs_nombre_particpanteid",
                table: "CARRERAs",
                column: "nombre_particpanteid",
                principalTable: "ALUMNOs",
                principalColumn: "id");
        }
    }
}
