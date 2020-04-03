using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ChangeFlightAddAircraftModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ACType",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AircraftRegistration",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Flights");

            migrationBuilder.AddColumn<int>(
                name: "AircraftCabinId",
                table: "Passengers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AircraftCabinId1",
                table: "Passengers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AircraftCabinId2",
                table: "Passengers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    AircraftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    AircraftRegistration = table.Column<string>(nullable: false),
                    Version = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.AircraftId);
                    table.ForeignKey(
                        name: "FK_Aircraft_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AircraftCabins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftCabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftCabins_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AircraftCabinId",
                table: "Passengers",
                column: "AircraftCabinId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AircraftCabinId1",
                table: "Passengers",
                column: "AircraftCabinId1");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AircraftCabinId2",
                table: "Passengers",
                column: "AircraftCabinId2");

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftCabins_AircraftId",
                table: "AircraftCabins",
                column: "AircraftId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId",
                table: "Passengers",
                column: "AircraftCabinId",
                principalTable: "AircraftCabins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId1",
                table: "Passengers",
                column: "AircraftCabinId1",
                principalTable: "AircraftCabins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId2",
                table: "Passengers",
                column: "AircraftCabinId2",
                principalTable: "AircraftCabins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId1",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId2",
                table: "Passengers");

            migrationBuilder.DropTable(
                name: "AircraftCabins");

            migrationBuilder.DropTable(
                name: "Aircraft");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_AircraftCabinId",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_AircraftCabinId1",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_AircraftCabinId2",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "AircraftCabinId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "AircraftCabinId1",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "AircraftCabinId2",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "ACType",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AircraftRegistration",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
