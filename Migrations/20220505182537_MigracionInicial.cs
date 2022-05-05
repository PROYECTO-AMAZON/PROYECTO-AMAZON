﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROYECTO_AMAZON.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ALUMNOs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apePat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apeMat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distrito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALUMNOs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALUMNOs");
        }
    }
}
