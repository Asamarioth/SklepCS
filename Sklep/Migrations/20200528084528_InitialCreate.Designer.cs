﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sklep.Data;

namespace Sklep.Migrations
{
    [DbContext(typeof(SklepContext))]
    [Migration("20200528084528_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sklep.Models.Kategorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kategorie");
                });

            modelBuilder.Entity("Sklep.Models.Producenci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Producenci");
                });

            modelBuilder.Entity("Sklep.Models.Produkty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena_brutto")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal?>("Cena_netto")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Id_kategorii")
                        .HasColumnType("int");

                    b.Property<string>("Id_obrazek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_producenta")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VAT")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Id_kategorii");

                    b.HasIndex("Id_producenta");

                    b.ToTable("Produkty");
                });

            modelBuilder.Entity("Sklep.Models.Produkty", b =>
                {
                    b.HasOne("Sklep.Models.Kategorie", "Kategorie")
                        .WithMany("Produkty")
                        .HasForeignKey("Id_kategorii")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sklep.Models.Producenci", "Producenci")
                        .WithMany("Produkty")
                        .HasForeignKey("Id_producenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
