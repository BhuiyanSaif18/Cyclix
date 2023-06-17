using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cyclix.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CycleBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CycleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CycleBrands",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 1, "Trek" },
                    { 2, "BMC" },
                    { 3, "Scott" }
                });

            migrationBuilder.InsertData(
                table: "CycleTypes",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 1, "Rennvelo" },
                    { 2, "Reisevelo" },
                    { 3, "Elektro Velo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CycleBrands");

            migrationBuilder.DropTable(
                name: "CycleTypes");
        }
    }
}
