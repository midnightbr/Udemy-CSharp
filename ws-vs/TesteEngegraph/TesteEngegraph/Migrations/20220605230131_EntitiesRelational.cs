using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteEngegraph.Migrations
{
    public partial class EntitiesRelational : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Tipos_TypeId",
                table: "Contatos");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Contatos",
                newName: "TypesId");

            migrationBuilder.RenameIndex(
                name: "IX_Contatos_TypeId",
                table: "Contatos",
                newName: "IX_Contatos_TypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Tipos_TypesId",
                table: "Contatos",
                column: "TypesId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Tipos_TypesId",
                table: "Contatos");

            migrationBuilder.RenameColumn(
                name: "TypesId",
                table: "Contatos",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Contatos_TypesId",
                table: "Contatos",
                newName: "IX_Contatos_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Tipos_TypeId",
                table: "Contatos",
                column: "TypeId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
