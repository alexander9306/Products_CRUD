using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea3_Ventas.Migrations
{
    public partial class LastCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductSubcategoryId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Damaso_Products");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Damaso_Products",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Damaso_Products",
                table: "Damaso_Products",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Damaso_Products",
                table: "Damaso_Products");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Damaso_Products");

            migrationBuilder.RenameTable(
                name: "Damaso_Products",
                newName: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductSubcategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");
        }
    }
}
