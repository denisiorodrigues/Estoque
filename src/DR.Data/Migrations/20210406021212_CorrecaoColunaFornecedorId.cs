using Microsoft.EntityFrameworkCore.Migrations;

namespace DR.Data.Migrations
{
    public partial class CorrecaoColunaFornecedorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_ForncedorId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "ForncedorId",
                table: "Produtos",
                newName: "FornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_ForncedorId",
                table: "Produtos",
                newName: "IX_Produtos_FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorId",
                table: "Produtos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "Produtos",
                newName: "ForncedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_FornecedorId",
                table: "Produtos",
                newName: "IX_Produtos_ForncedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_ForncedorId",
                table: "Produtos",
                column: "ForncedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
