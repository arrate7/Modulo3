﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Relacion1a1.Migrations
{
    [DbContext(typeof(Relacion1a1Context))]
    [Migration("20190613163149_dataannotations")]
    partial class dataannotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Relacion1a1.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nacionalidad")
                        .HasMaxLength(30);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Relacion1a1.Models.Biografia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId");

                    b.Property<DateTime>("FechaEdicion");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("AutorId")
                        .IsUnique();

                    b.ToTable("Biografia");
                });

            modelBuilder.Entity("Relacion1a1.Models.Dni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaExpiracion");

                    b.Property<string>("Identificador");

                    b.Property<int>("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Dni");
                });

            modelBuilder.Entity("Relacion1a1.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("Relacion1a1.Models.Biografia", b =>
                {
                    b.HasOne("Relacion1a1.Models.Autor", "Autor")
                        .WithOne("Biografia")
                        .HasForeignKey("Relacion1a1.Models.Biografia", "AutorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Relacion1a1.Models.Dni", b =>
                {
                    b.HasOne("Relacion1a1.Models.Persona", "Persona")
                        .WithOne("Dni")
                        .HasForeignKey("Relacion1a1.Models.Dni", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
