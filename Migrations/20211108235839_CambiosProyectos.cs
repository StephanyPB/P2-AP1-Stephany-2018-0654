using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_Stephany_2018_0654.Migrations
{
    public partial class CambiosProyectos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionProyecto",
                table: "Proyecto",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Proyecto",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ProyectoDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProyectoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TareasId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true),
                    Requerimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProyectoDetalle_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoDetalle_ProyectoId",
                table: "ProyectoDetalle",
                column: "ProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProyectoDetalle");

            migrationBuilder.DropColumn(
                name: "DescripcionProyecto",
                table: "Proyecto");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Proyecto");
        }
    }
}
