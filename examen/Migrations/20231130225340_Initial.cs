using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entreprises",
                columns: table => new
                {
                    IdEntreprise = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomEntreprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localisation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprises", x => x.IdEntreprise);
                });

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    IdOffre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OffreDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salaire = table.Column<int>(type: "int", nullable: false),
                    DomaineTravail = table.Column<int>(type: "int", nullable: false),
                    IdEntreprise = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.IdOffre);
                    table.ForeignKey(
                        name: "FK_Offres_Entreprises_IdEntreprise",
                        column: x => x.IdEntreprise,
                        principalTable: "Entreprises",
                        principalColumn: "IdEntreprise",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Demandes",
                columns: table => new
                {
                    IdDemande = table.Column<int>(type: "int", nullable: false),
                    IdOffre = table.Column<int>(type: "int", nullable: false),
                    NomCandidat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrenomCandidat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneCandidat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demandes", x => new { x.IdDemande, x.IdOffre });
                    table.ForeignKey(
                        name: "FK_Demandes_Offres_IdOffre",
                        column: x => x.IdOffre,
                        principalTable: "Offres",
                        principalColumn: "IdOffre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_IdOffre",
                table: "Demandes",
                column: "IdOffre");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_IdEntreprise",
                table: "Offres",
                column: "IdEntreprise");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demandes");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "Entreprises");
        }
    }
}
