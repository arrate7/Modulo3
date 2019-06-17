using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpresaWebApp.Migrations
{
    public partial class empresa2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Empresa_EmpresaId",
                table: "Departamento");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Departamento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Empresa_EmpresaId",
                table: "Departamento",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Empresa_EmpresaId",
                table: "Departamento");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Departamento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Empresa_EmpresaId",
                table: "Departamento",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
