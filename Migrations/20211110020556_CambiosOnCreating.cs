using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_Stephany_2018_0654.Migrations
{
    public partial class CambiosOnCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 1,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 10, 22, 5, 55, 733, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 2,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 10, 22, 5, 55, 733, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 3,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 10, 22, 5, 55, 733, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 4,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 10, 22, 5, 55, 733, DateTimeKind.Local).AddTicks(5012));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 1,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 2,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 3,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "TareasId",
                keyValue: 4,
                column: "FechaIngreso",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
