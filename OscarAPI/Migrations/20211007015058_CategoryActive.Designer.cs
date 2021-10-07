﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OscarAPI.Models;

namespace OscarAPI.Migrations
{
    [DbContext(typeof(OscarAPIContext))]
    [Migration("20211007015058_CategoryActive")]
    partial class CategoryActive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OscarAPI.Models.Nomination", b =>
                {
                    b.Property<int>("NominationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CategoryActive")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Film")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nominee")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Winner")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Year")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("NominationId");

                    b.ToTable("Nominations");
                });
#pragma warning restore 612, 618
        }
    }
}
