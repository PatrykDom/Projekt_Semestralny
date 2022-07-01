using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt_Semestralny.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gatunki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaGatunku = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gatunki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lekarze",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Pesel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lekarze", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opiekunowie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Wiek = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opiekunowie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacjenci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpiekunId = table.Column<int>(nullable: true),
                    LekarzId = table.Column<int>(nullable: true),
                    GatunekId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacjenci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacjenci_Gatunki_GatunekId",
                        column: x => x.GatunekId,
                        principalTable: "Gatunki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacjenci_Lekarze_LekarzId",
                        column: x => x.LekarzId,
                        principalTable: "Lekarze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacjenci_Opiekunowie_OpiekunId",
                        column: x => x.OpiekunId,
                        principalTable: "Opiekunowie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacjenci_GatunekId",
                table: "Pacjenci",
                column: "GatunekId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacjenci_LekarzId",
                table: "Pacjenci",
                column: "LekarzId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacjenci_OpiekunId",
                table: "Pacjenci",
                column: "OpiekunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacjenci");

            migrationBuilder.DropTable(
                name: "Gatunki");

            migrationBuilder.DropTable(
                name: "Lekarze");

            migrationBuilder.DropTable(
                name: "Opiekunowie");
        }
    }
}
