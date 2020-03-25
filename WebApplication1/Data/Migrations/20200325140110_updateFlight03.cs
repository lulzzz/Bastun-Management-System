using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class updateFlight03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AircraftConfiguration",
                table: "Flights");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Flights",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Flights",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Flights",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Flights");

            migrationBuilder.AddColumn<string>(
                name: "AircraftConfiguration",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
