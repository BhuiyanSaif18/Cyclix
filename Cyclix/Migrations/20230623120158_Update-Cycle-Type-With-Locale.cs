using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cyclix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCycleTypeWithLocale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lang",
                table: "CycleTypes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CycleTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "lang",
                value: "en");

            migrationBuilder.UpdateData(
                table: "CycleTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "lang",
                value: "en");

            migrationBuilder.UpdateData(
                table: "CycleTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "lang",
                value: "en");

            migrationBuilder.InsertData(
                table: "CycleTypes",
                columns: new[] { "Id", "lang", "name" },
                values: new object[,]
                {
                    { 4, "de", "Road bike" },
                    { 5, "de", "Trekking bike" },
                    { 6, "de", "Electric bike" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CycleTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CycleTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CycleTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "lang",
                table: "CycleTypes");
        }
    }
}
