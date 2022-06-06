using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteEngegraph.Migrations
{
    public partial class NovosParamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Tipos_TipoId",
                table: "Contatos");

            migrationBuilder.DropIndex(
                name: "IX_Contatos_TipoId",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Contatos");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Contatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_TypeId",
                table: "Contatos",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Tipos_TypeId",
                table: "Contatos",
                column: "TypeId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Tipos_TypeId",
                table: "Contatos");

            migrationBuilder.DropIndex(
                name: "IX_Contatos_TypeId",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Contatos");

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Contatos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_TipoId",
                table: "Contatos",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Tipos_TipoId",
                table: "Contatos",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
