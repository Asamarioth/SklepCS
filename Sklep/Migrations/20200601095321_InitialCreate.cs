using Microsoft.EntityFrameworkCore.Migrations;

namespace Sklep.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Producenci",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producenci", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Produkty",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_kategorii = table.Column<int>(nullable: false),
                    Id_producenta = table.Column<int>(nullable: false),
                    Nazwa = table.Column<string>(nullable: false),
                    Cena_netto = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    VAT = table.Column<int>(nullable: false),
                    Cena_brutto = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    Obrazek = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkty", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produkty_Kategorie_Id_kategorii",
                        column: x => x.Id_kategorii,
                        principalTable: "Kategorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produkty_Producenci_Id_producenta",
                        column: x => x.Id_producenta,
                        principalTable: "Producenci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produkty_Id_kategorii",
                table: "Produkty",
                column: "Id_kategorii");

            migrationBuilder.CreateIndex(
                name: "IX_Produkty_Id_producenta",
                table: "Produkty",
                column: "Id_producenta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produkty");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropTable(
                name: "Producenci");
        }
    }
}
