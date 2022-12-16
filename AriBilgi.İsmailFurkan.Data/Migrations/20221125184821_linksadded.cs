using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AriBilgi.İsmailFurkan.Data.Migrations
{
    public partial class linksadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 48, 20, 603, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Certificatess",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 48, 20, 604, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 48, 20, 605, DateTimeKind.Local).AddTicks(1557));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Link2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Link3",
                table: "Abouts");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 31, 46, 0, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Certificatess",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 31, 46, 1, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 31, 46, 2, DateTimeKind.Local).AddTicks(5804));
        }
    }
}
