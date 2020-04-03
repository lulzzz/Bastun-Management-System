using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class AddAircraftToFlightModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft");

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft",
                column: "FlightId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft");

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft",
                column: "FlightId");
        }
    }
}
