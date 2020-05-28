using Microsoft.EntityFrameworkCore.Migrations;

namespace Sklep.Migrations
{
    public partial class TableRestraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_obrazek",
                table: "Produkty");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "Produkty",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Obrazek",
                table: "Produkty",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Obrazek",
                table: "Produkty");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "Produkty",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Id_obrazek",
                table: "Produkty",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
