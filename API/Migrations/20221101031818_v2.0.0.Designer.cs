﻿// <auto-generated />
using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20221101031818_v2.0.0")]
    partial class v200
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Estudiantes", b =>
                {
                    b.Property<int>("idEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEstudiante");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("API.Models.Profesores", b =>
                {
                    b.Property<int>("idProfesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("materia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreProfesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProfesor");

                    b.ToTable("Profesores");
                });
#pragma warning restore 612, 618
        }
    }
}