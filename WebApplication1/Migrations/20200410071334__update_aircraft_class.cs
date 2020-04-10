using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class _update_aircraft_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_OutboundFlights_OutboundFlightId",
                table: "Aircraft");

            migrationBuilder.DropForeignKey(
                name: "FK_AircraftBaggageHolds_Aircraft_AircraftId",
                table: "AircraftBaggageHolds");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_OutboundFlights_OutboundFlightId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureMovements_OutboundFlights_OutboundFlightId",
                table: "DepartureMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_OutboundFlights_OutboundFlightId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_AircraftBaggageHolds_AircraftId",
                table: "AircraftBaggageHolds");

            migrationBuilder.AddColumn<int>(
                name: "AircraftBaggageHoldId",
                table: "Aircraft",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AircraftBaggageHolds_AircraftId",
                table: "AircraftBaggageHolds",
                column: "AircraftId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_OutboundFlights_OutboundFlightId",
                table: "Aircraft",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftBaggageHolds_Aircraft_AircraftId",
                table: "AircraftBaggageHolds",
                column: "AircraftId",
                principalTable: "Aircraft",
                principalColumn: "AircraftId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_OutboundFlights_OutboundFlightId",
                table: "Containers",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureMovements_OutboundFlights_OutboundFlightId",
                table: "DepartureMovements",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_OutboundFlights_OutboundFlightId",
                table: "Messages",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_OutboundFlights_OutboundFlightId",
                table: "Aircraft");

            migrationBuilder.DropForeignKey(
                name: "FK_AircraftBaggageHolds_Aircraft_AircraftId",
                table: "AircraftBaggageHolds");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_OutboundFlights_OutboundFlightId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureMovements_OutboundFlights_OutboundFlightId",
                table: "DepartureMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_OutboundFlights_OutboundFlightId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_AircraftBaggageHolds_AircraftId",
                table: "AircraftBaggageHolds");

            migrationBuilder.DropColumn(
                name: "AircraftBaggageHoldId",
                table: "Aircraft");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftBaggageHolds_AircraftId",
                table: "AircraftBaggageHolds",
                column: "AircraftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_OutboundFlights_OutboundFlightId",
                table: "Aircraft",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftBaggageHolds_Aircraft_AircraftId",
                table: "AircraftBaggageHolds",
                column: "AircraftId",
                principalTable: "Aircraft",
                principalColumn: "AircraftId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_OutboundFlights_OutboundFlightId",
                table: "Containers",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureMovements_OutboundFlights_OutboundFlightId",
                table: "DepartureMovements",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_OutboundFlights_OutboundFlightId",
                table: "Messages",
                column: "OutboundFlightId",
                principalTable: "OutboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
