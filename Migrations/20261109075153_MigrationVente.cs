using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migration_BD_Gestionnaire_Supermarché.Migrations
{
    /// <inheritdoc />
    public partial class MigrationVente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventes",
                columns: table => new
                {
                    Id_Vente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Produit = table.Column<int>(type: "int", nullable: false),
                    Date_Vente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantite_Vendue = table.Column<int>(type: "int", nullable: false),
                    Prix_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventes", x => x.Id_Vente);
                    table.ForeignKey(
                        name: "FK_Ventes_Produits_Id_Produit",
                        column: x => x.Id_Produit,
                        principalTable: "Produits",
                        principalColumn: "Id_Produit",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventes_Id_Produit",
                table: "Ventes",
                column: "Id_Produit");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventes");

        }
    }
}
