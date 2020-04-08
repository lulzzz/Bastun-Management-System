using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _test_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_Flights_FlightId",
                table: "Aircraft");

            migrationBuilder.DropForeignKey(
                name: "FK_ArrivalMovements_Flights_FlightRef",
                table: "ArrivalMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureMovements_Flights_FlightRef",
                table: "DepartureMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadDistributionMessages_Flights_FlightRef",
                table: "LoadDistributionMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId1",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_AircraftCabins_AircraftCabinId2",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Flights_FlightId",
                table: "Passengers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_AircraftCabinId1",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_AircraftCabinId2",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_FlightId",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_DepartureMovements_FlightRef",
                table: "DepartureMovements");

            migrationBuilder.DropIndex(
                name: "IX_ArrivalMovements_FlightRef",
                table: "ArrivalMovements");

            migrationBuilder.DropIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoadDistributionMessages",
                table: "LoadDistributionMessages");

            migrationBuilder.DropIndex(
                name: "IX_LoadDistributionMessages_FlightRef",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "AircraftCabinId1",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "AircraftCabinId2",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "FlightRef",
                table: "DepartureMovements");

            migrationBuilder.DropColumn(
                name: "FlightRef",
                table: "ArrivalMovements");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "CargoWeight",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "FlightRef",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "PAXInfant",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "PayloadPerCompartments",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "TotalBags",
                table: "LoadDistributionMessages");

            migrationBuilder.DropColumn(
                name: "TotalPayloadWeight",
                table: "LoadDistributionMessages");

            migrationBuilder.RenameTable(
                name: "LoadDistributionMessages",
                newName: "Messages");

            migrationBuilder.RenameColumn(
                name: "TotalPAX",
                table: "Messages",
                newName: "TotalPax");

            migrationBuilder.AddColumn<int>(
                name: "ZoneAlphaCapacity",
                table: "AircraftCabins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZoneBravoCapacity",
                table: "AircraftCabins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZoneCharlieCapacity",
                table: "AircraftCabins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZoneDeltaCapacity",
                table: "AircraftCabins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuelFormId",
                table: "Aircraft",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAicraftContainerized",
                table: "Aircraft",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "WeightFormId",
                table: "Aircraft",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalPax",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PAXMale",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PAXFemale",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PAXChildren",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContainerInfoId",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PAXInfants",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TTLWeightInCPT1",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TTLWeightInCPT2",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TTLWeightInCPT4",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TTLWeightInCPT5",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TTlWeightINCPT3",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalBaggagePieces",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalCargo",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalWeightInAllCompartments",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Messages",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Messages",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InboundFlightId",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OutboundFlightId",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "MessageId");

            migrationBuilder.CreateTable(
                name: "AircraftBaggageHolds",
                columns: table => new
                {
                    BaggageHoldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(nullable: false),
                    CompartmentOneCapacity = table.Column<int>(nullable: false),
                    CompartmentOneTotalWeight = table.Column<int>(nullable: false),
                    CompartmentTwoCapacity = table.Column<int>(nullable: false),
                    CompartmentTwoTotalWeight = table.Column<int>(nullable: false),
                    CompartmentThreeCapacity = table.Column<int>(nullable: false),
                    CompartmentThreeTotalWeight = table.Column<int>(nullable: false),
                    CompartmentFourCapacity = table.Column<int>(nullable: false),
                    CompartmentFourTotalWeight = table.Column<int>(nullable: false),
                    CompartmentFiveCapacity = table.Column<int>(nullable: false),
                    CompartmentFiveTotalWeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftBaggageHolds", x => x.BaggageHoldId);
                    table.ForeignKey(
                        name: "FK_AircraftBaggageHolds_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuelForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(nullable: false),
                    PilotInCommand = table.Column<string>(nullable: false),
                    CrewConfiguration = table.Column<string>(nullable: false),
                    TaxiFuel = table.Column<double>(nullable: false),
                    BlockFuel = table.Column<double>(nullable: false),
                    TripFuel = table.Column<double>(nullable: false),
                    DryOperatingWeight = table.Column<double>(nullable: false),
                    DryOperatingIndex = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelForms_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InboundFlights",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(nullable: true),
                    ArrivalMovementId = table.Column<int>(nullable: true),
                    STA = table.Column<DateTime>(nullable: false),
                    Origin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InboundFlights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_InboundFlights_ArrivalMovements_ArrivalMovementId",
                        column: x => x.ArrivalMovementId,
                        principalTable: "ArrivalMovements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutboundFlights",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(nullable: true),
                    AircraftId = table.Column<int>(nullable: false),
                    HandlingStation = table.Column<string>(nullable: true),
                    DepartureMovementId = table.Column<int>(nullable: true),
                    STD = table.Column<DateTime>(nullable: false),
                    BookedPax = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutboundFlights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_OutboundFlights_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutboundFlights_DepartureMovements_DepartureMovementId",
                        column: x => x.DepartureMovementId,
                        principalTable: "DepartureMovements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeightForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(nullable: false),
                    AircraftBasicWeight = table.Column<double>(nullable: false),
                    MaximumZeroFuelWeight = table.Column<double>(nullable: false),
                    MaximumLandingWeight = table.Column<double>(nullable: false),
                    MaximumTakeoffWeight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightForms_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    ContainerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutboundFlightId = table.Column<int>(nullable: false),
                    ContainerInfoId = table.Column<int>(nullable: false),
                    ContainerPieces = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.ContainerId);
                    table.ForeignKey(
                        name: "FK_Containers_OutboundFlights_OutboundFlightId",
                        column: x => x.OutboundFlightId,
                        principalTable: "OutboundFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContainerInfos",
                columns: table => new
                {
                    ContainerInfoId = table.Column<int>(nullable: false),
                    ContainerId = table.Column<int>(nullable: false),
                    ContainerPalletMessageId = table.Column<int>(nullable: false),
                    UniloadContainerMessageId = table.Column<int>(nullable: false),
                    ContainerPosition = table.Column<string>(nullable: true),
                    ContainerNumberAndType = table.Column<int>(nullable: false),
                    ContainerTotalWeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerInfos", x => x.ContainerInfoId);
                    table.ForeignKey(
                        name: "FK_ContainerInfos_Containers_ContainerInfoId",
                        column: x => x.ContainerInfoId,
                        principalTable: "Containers",
                        principalColumn: "ContainerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContainerInfos_Messages_ContainerPalletMessageId",
                        column: x => x.ContainerPalletMessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContainerInfos_Messages_UniloadContainerMessageId",
                        column: x => x.UniloadContainerMessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_InboundFlightId",
                table: "Messages",
                column: "InboundFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_OutboundFlightId",
                table: "Messages",
                column: "OutboundFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftBaggageHolds_AircraftId",
                table: "AircraftBaggageHolds",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerInfos_ContainerPalletMessageId",
                table: "ContainerInfos",
                column: "ContainerPalletMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerInfos_UniloadContainerMessageId",
                table: "ContainerInfos",
                column: "UniloadContainerMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_OutboundFlightId",
                table: "Containers",
                column: "OutboundFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelForms_AircraftId",
                table: "FuelForms",
                column: "AircraftId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InboundFlights_ArrivalMovementId",
                table: "InboundFlights",
                column: "ArrivalMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_OutboundFlights_AircraftId",
                table: "OutboundFlights",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_OutboundFlights_DepartureMovementId",
                table: "OutboundFlights",
                column: "DepartureMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightForms_AircraftId",
                table: "WeightForms",
                column: "AircraftId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_InboundFlights_InboundFlightId",
                table: "Messages",
                column: "InboundFlightId",
                principalTable: "InboundFlights",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_InboundFlights_InboundFlightId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_OutboundFlights_OutboundFlightId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "AircraftBaggageHolds");

            migrationBuilder.DropTable(
                name: "ContainerInfos");

            migrationBuilder.DropTable(
                name: "FuelForms");

            migrationBuilder.DropTable(
                name: "InboundFlights");

            migrationBuilder.DropTable(
                name: "WeightForms");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "OutboundFlights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_InboundFlightId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_OutboundFlightId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ZoneAlphaCapacity",
                table: "AircraftCabins");

            migrationBuilder.DropColumn(
                name: "ZoneBravoCapacity",
                table: "AircraftCabins");

            migrationBuilder.DropColumn(
                name: "ZoneCharlieCapacity",
                table: "AircraftCabins");

            migrationBuilder.DropColumn(
                name: "ZoneDeltaCapacity",
                table: "AircraftCabins");

            migrationBuilder.DropColumn(
                name: "FuelFormId",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "IsAicraftContainerized",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "WeightFormId",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "ContainerInfoId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "PAXInfants",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TTLWeightInCPT1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TTLWeightInCPT2",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TTLWeightInCPT4",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TTLWeightInCPT5",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TTlWeightINCPT3",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TotalBaggagePieces",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TotalCargo",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TotalWeightInAllCompartments",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "InboundFlightId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "OutboundFlightId",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "LoadDistributionMessages");

            migrationBuilder.RenameColumn(
                name: "TotalPax",
                table: "LoadDistributionMessages",
                newName: "TotalPAX");

            migrationBuilder.AddColumn<int>(
                name: "AircraftCabinId1",
                table: "Passengers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AircraftCabinId2",
                table: "Passengers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlightRef",
                table: "DepartureMovements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlightRef",
                table: "ArrivalMovements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Aircraft",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalPAX",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PAXMale",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PAXFemale",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PAXChildren",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CargoWeight",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlightRef",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PAXInfant",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PayloadPerCompartments",
                table: "LoadDistributionMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalBags",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPayloadWeight",
                table: "LoadDistributionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoadDistributionMessages",
                table: "LoadDistributionMessages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookedPax = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    STA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STD = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AircraftCabinId1",
                table: "Passengers",
                column: "AircraftCabinId1");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AircraftCabinId2",
                table: "Passengers",
                column: "AircraftCabinId2");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_FlightId",
                table: "Passengers",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartureMovements_FlightRef",
                table: "DepartureMovements",
                column: "FlightRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArrivalMovements_FlightRef",
                table: "ArrivalMovements",
                column: "FlightRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_FlightId",
                table: "Aircraft",
                column: "FlightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoadDistributionMessages_FlightRef",
                table: "LoadDistributionMessages",
                column: "FlightRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_Flights_FlightId",
                table: "Aircraft",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArrivalMovements_Flights_FlightRef",
                table: "ArrivalMovements",
                column: "FlightRef",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureMovements_Flights_FlightRef",
                table: "DepartureMovements",
                column: "FlightRef",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoadDistributionMessages_Flights_FlightRef",
                table: "LoadDistributionMessages",
                column: "FlightRef",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Flights_FlightId",
                table: "Passengers",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
