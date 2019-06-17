﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmpresaWebApp.Migrations
{
    [DbContext(typeof(EmpresaWebAppContext))]
    [Migration("20190617100543_empresa2")]
    partial class empresa2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmpresaWebApp.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasMaxLength(3);

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("EmpresaWebApp.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("EmpresaWebApp.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cif")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("EmpresaWebApp.Models.Departamento", b =>
                {
                    b.HasOne("EmpresaWebApp.Models.Empresa", "Empresa")
                        .WithMany("Departamentos")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("EmpresaWebApp.Models.Empleado", b =>
                {
                    b.HasOne("EmpresaWebApp.Models.Departamento", "Departamento")
                        .WithMany("Empleados")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
