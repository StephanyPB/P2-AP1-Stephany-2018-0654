using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_Stephany_2018_0654.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.ProyectoId);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    TareasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TiempoTarea = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.TareasId);
                });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareasId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 1, new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Analisis" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareasId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 2, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Diseño" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareasId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 3, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Programacion" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareasId", "FechaIngreso", "TiempoTarea", "TipoTarea" },
                values: new object[] { 4, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Prueba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
