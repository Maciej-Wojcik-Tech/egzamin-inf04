using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NOrgnizer1.Migrations
{
    /// <inheritdoc />
    public partial class dsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zadania",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Waznosc = table.Column<int>(type: "int", nullable: false),
                    Grupa = table.Column<int>(type: "int", nullable: false),
                    DataWykonania = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPrzypomnienia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataZakonczenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tresc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zadania", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zadania");
        }
    }
}
