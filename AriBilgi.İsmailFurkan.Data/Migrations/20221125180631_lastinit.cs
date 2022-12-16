using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AriBilgi.İsmailFurkan.Data.Migrations
{
    public partial class lastinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 6, 30, 607, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Certificatess",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 6, 30, 609, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 6, 30, 610, DateTimeKind.Local).AddTicks(1987));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Educations");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 17, 3, 3, 481, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Certificatess",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 17, 3, 3, 483, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 17, 3, 3, 484, DateTimeKind.Local).AddTicks(128));
        }
    }
}
