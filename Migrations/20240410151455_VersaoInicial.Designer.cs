﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace delivri.Migrations
{
    [DbContext(typeof(BDD))]
    [Migration("20240410151455_VersaoInicial")]
    partial class VersaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lojas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Nota")
                        .HasColumnType("float");

                    b.Property<float>("Taxa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Lojas");
                });
#pragma warning restore 612, 618
        }
    }
}
