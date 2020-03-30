using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _updateFlightClass04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passenger_Flights_FlightId",
                table: "Passenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Suitcase_Passenger_PassengerPaxId",
                table: "Suitcase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suitcase",
                table: "Suitcase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passenger",
                table: "Passenger");

            migrationBuilder.RenameTable(
                name: "Suitcase",
                newName: "Suitcases");

            migrationBuilder.RenameTable(
                name: "Passenger",
                newName: "Passengers");

            migrationBuilder.RenameIndex(
                name: "IX_Suitcase_PassengerPaxId",
                table: "Suitcases",
                newName: "IX_Suitcases_PassengerPaxId");

            migrationBuilder.RenameIndex(
                name: "IX_Passenger_FlightId",
                table: "Passengers",
                newName: "IX_Passengers_FlightId");

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Flights",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suitcases",
                table: "Suitcases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PaxId");

            migrationBuilder.CreateTable(
                name: "ArrivalMovements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightRef = table.Column<int>(nullable: false),
                    OnBlockTime = table.Column<DateTime>(nullable: false),
                    SupplementaryInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrivalMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArrivalMovements_Flights_FlightRef",
                        column: x => x.FlightRef,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartureMovements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightRef = table.Column<int>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    OffBlockTime = table.Column<DateTime>(nullable: false),
                    TakeoffTime = table.Column<DateTime>(nullable: false),
                    TotalPAX = table.Column<int>(nullable: false),
                    SupplementaryInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartureMovements_Flights_FlightRef",
                        column: x => x.FlightRef,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArrivalMovements_FlightRef",
                table: "ArrivalMovements",
                column: "FlightRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepartureMovements_FlightRef",
                table: "DepartureMovements",
                column: "FlightRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Flights_FlightId",
                table: "Passengers",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suitcases_Passengers_PassengerPaxId",
                table: "Suitcases",
                column: "PassengerPaxId",
                principalTable: "Passengers",
                principalColumn: "PaxId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Flights_FlightId",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suitcases_Passengers_PassengerPaxId",
                table: "Suitcases");

            migrationBuilder.DropTable(
                name: "ArrivalMovements");

            migrationBuilder.DropTable(
                name: "DepartureMovements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suitcases",
                table: "Suitcases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Suitcases",
                newName: "Suitcase");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "Passenger");

            migrationBuilder.RenameIndex(
                name: "IX_Suitcases_PassengerPaxId",
                table: "Suitcase",
                newName: "IX_Suitcase_PassengerPaxId");

            migrationBuilder.RenameIndex(
                name: "IX_Passengers_FlightId",
                table: "Passenger",
                newName: "IX_Passenger_FlightId");

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suitcase",
                table: "Suitcase",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passenger",
                table: "Passenger",
                column: "PaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passenger_Flights_FlightId",
                table: "Passenger",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suitcase_Passenger_PassengerPaxId",
                table: "Suitcase",
                column: "PassengerPaxId",
                principalTable: "Passenger",
                principalColumn: "PaxId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
