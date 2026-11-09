using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migration_BD_Gestionnaire_Supermarché.Migrations
{
    /// <inheritdoc />
    public partial class MigrationProduit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id_Produit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Produit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix_Unitaire = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantite_Stock = table.Column<int>(type: "int", nullable: false),
                    Id_Rayon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id_Produit);
                    table.ForeignKey(
                        name: "FK_Produits_Rayons_Id_Rayon",
                        column: x => x.Id_Rayon,
                        principalTable: "Rayons",
                        principalColumn: "Id_Rayon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produits_Id_Rayon",
                table: "Produits",
                column: "Id_Rayon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");

        }
    }
}
