using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Relacion1a1.Migrations
{
    public partial class autor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Biografia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    FechaEdicion = table.Column<DateTime>(nullable: false),
                    AutorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biografia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biografia_Autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biografia_AutorId",
                table: "Biografia",
                column: "AutorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biografia");

            migrationBuilder.DropTable(
                name: "Autor");
        }
    }
}
