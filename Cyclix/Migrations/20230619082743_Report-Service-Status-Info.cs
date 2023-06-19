using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyclix.Migrations
{
    /// <inheritdoc />
    public partial class ReportServiceStatusInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "RepairRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "isResolved",
                table: "RepairRequests",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "RepairRequests");

            migrationBuilder.DropColumn(
                name: "isResolved",
                table: "RepairRequests");
        }
    }
}
