using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migration_BD_Gestionnaire_Supermarché.Migrations
{
    /// <inheritdoc />
    public partial class MigrationRayon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Rayons",
                columns: table => new
                {
                    Id_Rayon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Rayon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rayons", x => x.Id_Rayon);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rayons");
        }
    }
}
