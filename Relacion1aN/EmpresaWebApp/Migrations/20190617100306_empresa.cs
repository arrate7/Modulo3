using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpresaWebApp.Migrations
{
    public partial class empresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Departamento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: true),
                    Cif = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_EmpresaId",
                table: "Departamento",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Empresa_EmpresaId",
                table: "Departamento",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Empresa_EmpresaId",
                table: "Departamento");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Departamento_EmpresaId",
                table: "Departamento");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Departamento");
        }
    }
}
