using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestEfCodeFirst.Migrations
{
    public partial class Deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Takim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<string>(type: "text", nullable: false),
                    YoneticiId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupTakim",
                columns: table => new
                {
                    GruplarId = table.Column<int>(type: "integer", nullable: false),
                    TakimlarId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupTakim", x => new { x.GruplarId, x.TakimlarId });
                    table.ForeignKey(
                        name: "FK_GrupTakim_Grup_GruplarId",
                        column: x => x.GruplarId,
                        principalTable: "Grup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupTakim_Takim_TakimlarId",
                        column: x => x.TakimlarId,
                        principalTable: "Takim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adi = table.Column<int>(type: "integer", nullable: false),
                    Soyadi = table.Column<int>(type: "integer", nullable: false),
                    TakimId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kisi_Takim_TakimId",
                        column: x => x.TakimId,
                        principalTable: "Takim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrupKisiVeri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrupId = table.Column<int>(type: "integer", nullable: false),
                    KisiId = table.Column<int>(type: "integer", nullable: false),
                    Puan = table.Column<int>(type: "integer", nullable: false),
                    Derece = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupKisiVeri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupKisiVeri_Grup_GrupId",
                        column: x => x.GrupId,
                        principalTable: "Grup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupKisiVeri_Kisi_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupKisiVeri_GrupId",
                table: "GrupKisiVeri",
                column: "GrupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GrupKisiVeri_KisiId",
                table: "GrupKisiVeri",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupTakim_TakimlarId",
                table: "GrupTakim",
                column: "TakimlarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kisi_TakimId",
                table: "Kisi",
                column: "TakimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupKisiVeri");

            migrationBuilder.DropTable(
                name: "GrupTakim");

            migrationBuilder.DropTable(
                name: "Kisi");

            migrationBuilder.DropTable(
                name: "Grup");

            migrationBuilder.DropTable(
                name: "Takim");
        }
    }
}
