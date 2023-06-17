using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyclix.Migrations
{
    /// <inheritdoc />
    public partial class RepairRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepairRequests",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cycleType = table.Column<string>(type: "TEXT", nullable: false),
                    brandName = table.Column<string>(type: "TEXT", nullable: false),
                    servicePricingOption = table.Column<string>(type: "TEXT", nullable: false),
                    skipServicePackage = table.Column<bool>(type: "INTEGER", nullable: false),
                    isElectricCycle = table.Column<bool>(type: "INTEGER", nullable: false),
                    tubeOrTire = table.Column<bool>(type: "INTEGER", nullable: false),
                    wheelCentering = table.Column<bool>(type: "INTEGER", nullable: false),
                    adjustingGears = table.Column<bool>(type: "INTEGER", nullable: false),
                    adjectBreaks = table.Column<bool>(type: "INTEGER", nullable: false),
                    changeBreakPads = table.Column<bool>(type: "INTEGER", nullable: false),
                    suspension = table.Column<bool>(type: "INTEGER", nullable: false),
                    completeCleaning = table.Column<bool>(type: "INTEGER", nullable: false),
                    lightCheck = table.Column<bool>(type: "INTEGER", nullable: false),
                    functionCheck = table.Column<bool>(type: "INTEGER", nullable: false),
                    batteryCheck = table.Column<bool>(type: "INTEGER", nullable: false),
                    moreDetailedIssue = table.Column<string>(type: "TEXT", nullable: false),
                    estimatedCost = table.Column<double>(type: "REAL", nullable: false),
                    firstName = table.Column<string>(type: "TEXT", nullable: false),
                    lastName = table.Column<string>(type: "TEXT", nullable: false),
                    street = table.Column<string>(type: "TEXT", nullable: false),
                    nr = table.Column<string>(type: "TEXT", nullable: false),
                    city = table.Column<string>(type: "TEXT", nullable: false),
                    zipCode = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairRequests", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairRequests");
        }
    }
}
