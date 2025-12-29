using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SatisTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class Gecis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SatisKaydi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirmaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    SorumluSatisci = table.Column<string>(type: "TEXT", nullable: false),
                    FirmaMail = table.Column<string>(type: "TEXT", nullable: false),
                    FirmaTelefon = table.Column<string>(type: "TEXT", nullable: false),
                    Durum = table.Column<string>(type: "TEXT", nullable: false),
                    Notlar = table.Column<string>(type: "TEXT", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisKaydi", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SatisKaydi");
        }
    }
}
