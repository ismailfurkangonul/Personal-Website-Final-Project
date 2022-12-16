using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AriBilgi.İsmailFurkan.Data.Migrations
{
    public partial class imagesabout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Abouts");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 10, 36, 189, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Certificatess",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 10, 36, 190, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 21, 10, 36, 191, DateTimeKind.Local).AddTicks(5532));
        }
    }
}
