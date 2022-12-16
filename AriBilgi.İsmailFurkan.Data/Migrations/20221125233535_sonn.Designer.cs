﻿// <auto-generated />
using System;
using AriBilgi.IsmailFurkan.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AriBilgi.İsmailFurkan.Data.Migrations
{
    [DbContext(typeof(IsmailFurkanContext))]
    [Migration("20221125233535_sonn")]
    partial class sonn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AriBilgi.IsmailFurkan.Entities.Concrete.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explain")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Social")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 11, 26, 2, 35, 34, 836, DateTimeKind.Local).AddTicks(8584),
                            Explain = "Yazılım",
                            Name = "İsmail Furkan Gönül"
                        });
                });

            modelBuilder.Entity("AriBilgi.IsmailFurkan.Entities.Concrete.Certificates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Certificate1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Certificatess");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Certificate1 = "2020 Yılı EuroPass Sertifikası",
                            Certificate2 = "2022 Yılı (HackerRank) C# Sertifikası",
                            Certificate3 = "2022 Yılı (Bilgeİş) HTML Sertifikası",
                            Certificate4 = "2022 Yılı (Bilgeİş) CSS Sertifikası",
                            Certificate5 = "2022 Yılı (HackerRank) SQL Sertifikası",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 11, 26, 2, 35, 34, 838, DateTimeKind.Local).AddTicks(4276),
                            Title = "Certificates"
                        });
                });

            modelBuilder.Entity("AriBilgi.IsmailFurkan.Entities.Concrete.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schoolname1")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Schoolname2")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Schoolsubtitle1")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Schoolsubtitle2")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 11, 26, 2, 35, 34, 839, DateTimeKind.Local).AddTicks(1837),
                            Schoolname1 = "Üsküdar Lisesi",
                            Schoolname2 = "Beykoz Üniversitesi",
                            Schoolsubtitle1 = "Meslek Lisesi",
                            Schoolsubtitle2 = "Lojistik",
                            Title = "Eğitim"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
