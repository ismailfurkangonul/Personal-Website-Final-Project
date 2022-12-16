using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AriBilgi.İsmailFurkan.Data.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates");

            migrationBuilder.RenameTable(
                name: "Certificates",
                newName: "Certificatess");

            migrationBuilder.RenameColumn(
                name: "Explain",
                table: "Certificatess",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Certificate1",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate2",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate3",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate4",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate5",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate6",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificatess",
                table: "Certificatess",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 0, 0, 21, 535, DateTimeKind.Local).AddTicks(7286));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificatess",
                table: "Certificatess");

            migrationBuilder.DropColumn(
                name: "Certificate1",
                table: "Certificatess");

            migrationBuilder.DropColumn(
                name: "Certificate2",
                table: "Certificatess");

            migrationBuilder.DropColumn(
                name: "Certificate3",
                table: "Certificatess");

            migrationBuilder.DropColumn(
                name: "Certificate4",
                table: "Certificatess");

            migrationBuilder.DropColumn(
                name: "Certificate5",
                table: "Certificatess");

            migrationBuilder.DropColumn(
                name: "Certificate6",
                table: "Certificatess");

            migrationBuilder.RenameTable(
                name: "Certificatess",
                newName: "Certificates");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Certificates",
                newName: "Explain");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 23, 23, 25, 33, 294, DateTimeKind.Local).AddTicks(7178));
        }
    }
}
