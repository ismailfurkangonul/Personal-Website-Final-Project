using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AriBilgi.İsmailFurkan.Data.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "GNO",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Education");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Certificatess",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Educations",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schoolname1",
                table: "Educations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schoolname2",
                table: "Educations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schoolsubtitle1",
                table: "Educations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schoolsubtitle2",
                table: "Educations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 17, 3, 3, 481, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.InsertData(
                table: "Certificatess",
                columns: new[] { "Id", "Certificate1", "Certificate2", "Certificate3", "Certificate4", "Certificate5", "Certificate6", "CreatedBy", "CreatedDate", "Title" },
                values: new object[] { 1, "2020 Yılı EuroPass Sertifikası", "2022 Yılı (HackerRank) C# Sertifikası", "2022 Yılı (Bilgeİş) HTML Sertifikası", "2022 Yılı (Bilgeİş) CSS Sertifikası", "2022 Yılı (HackerRank) SQL Sertifikası", null, 1, new DateTime(2022, 11, 25, 17, 3, 3, 483, DateTimeKind.Local).AddTicks(3134), "Certificates" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Schoolname1", "Schoolname2", "Schoolsubtitle1", "Schoolsubtitle2", "Title" },
                values: new object[] { 1, 1, new DateTime(2022, 11, 25, 17, 3, 3, 484, DateTimeKind.Local).AddTicks(128), "Üsküdar Lisesi", "Beykoz Üniversitesi", "Meslek Lisesi", "Lojistik", "Eğitim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.DeleteData(
                table: "Certificatess",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Schoolname1",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Schoolname2",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Schoolsubtitle1",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Schoolsubtitle2",
                table: "Educations");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Certificatess",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Education",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AddColumn<string>(
                name: "GNO",
                table: "Education",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Education",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 25, 0, 0, 21, 535, DateTimeKind.Local).AddTicks(7286));
        }
    }
}
