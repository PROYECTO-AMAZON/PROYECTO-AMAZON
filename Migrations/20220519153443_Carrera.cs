using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROYECTO_AMAZON.Migrations
{
    public partial class Carrera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "departamento",
                table: "ALUMNOs");

            migrationBuilder.DropColumn(
                name: "distrito",
                table: "ALUMNOs");

            migrationBuilder.DropColumn(
                name: "provincia",
                table: "ALUMNOs");

            migrationBuilder.CreateTable(
                name: "CARRERAs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecCarrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distancia = table.Column<double>(type: "float", nullable: false),
                    tiempo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARRERAs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CARRERAs");

            migrationBuilder.AddColumn<string>(
                name: "departamento",
                table: "ALUMNOs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "distrito",
                table: "ALUMNOs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "provincia",
                table: "ALUMNOs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
