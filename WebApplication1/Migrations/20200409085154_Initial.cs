using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InboundFlights",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(nullable: false),
                    ArrivalMovementId = table.Column<int>(nullable: false),
                    STA = table.Column<DateTime>(nullable: false),
                    Origin = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InboundFlights", x => x.FlightId);
                });

            migrationBuilder.CreateTable(
                name: "OutboundFlights",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(nullable: false),
                    AircraftId = table.Column<int>(nullable: false),
                    HandlingStation = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: false),
                    DepartureMovementId = table.Column<int>(nullable: false),
                    STD = table.Column<DateTime>(nullable: false),
                    BookedPax = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutboundFlights", x => x.FlightId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArrivalMovements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InboundFlightId = table.Column<int>(nullable: false),
                    DateOfMovement = table.Column<DateTime>(nullable: false),
                    TouchdownTime = table.Column<DateTime>(nullable: false),
                    OnBlockTime = table.Column<DateTime>(nullable: false),
                    SupplementaryInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrivalMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArrivalMovements_InboundFlights_InboundFlightId",
                        column: x => x.InboundFlightId,
                        principalTable: "InboundFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    AircraftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    AircraftRegistration = table.Column<string>(nullable: false),
                    OutboundFlightId = table.Column<int>(nullable: false),
                    Version = table.Column<string>(nullable: false),
                    AircraftCabinId = table.Column<int>(nullable: false),
                    FuelFormId = table.Column<int>(nullable: false),
                    WeightFormId = table.Column<int>(nullable: false),
                    IsAicraftContainerized = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.AircraftId);
                    table.ForeignKey(
                        name: "FK_Aircraft_OutboundFlights_OutboundFlightId",
                        column: x => x.OutboundFlightId,
                        principalTable: "OutboundFlights",
                        principalColumn: "FlightId",
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
                name: "DepartureMovements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfMovement = table.Column<DateTime>(nullable: false),
                    OffBlockTime = table.Column<DateTime>(nullable: false),
                    TakeoffTime = table.Column<DateTime>(nullable: false),
                    OutboundFlightId = table.Column<int>(nullable: false),
                    TotalPAX = table.Column<int>(nullable: false),
                    SupplementaryInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartureMovements_OutboundFlights_OutboundFlightId",
                        column: x => x.OutboundFlightId,
                        principalTable: "OutboundFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InboundFlightId = table.Column<int>(nullable: false),
                    OutboundFlightId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ContainerInfoId = table.Column<int>(nullable: true),
                    CrewConfiguration = table.Column<string>(nullable: true),
                    PAXMale = table.Column<int>(nullable: true),
                    PAXFemale = table.Column<int>(nullable: true),
                    PAXChildren = table.Column<int>(nullable: true),
                    PAXInfants = table.Column<int>(nullable: true),
                    TotalWeightInAllCompartments = table.Column<int>(nullable: true),
                    TTLWeightInCPT1 = table.Column<int>(nullable: true),
                    TTLWeightInCPT2 = table.Column<int>(nullable: true),
                    TTlWeightINCPT3 = table.Column<int>(nullable: true),
                    TTLWeightInCPT4 = table.Column<int>(nullable: true),
                    TTLWeightInCPT5 = table.Column<int>(nullable: true),
                    TotalPax = table.Column<int>(nullable: true),
                    TotalBaggagePieces = table.Column<int>(nullable: true),
                    TotalCargo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_InboundFlights_InboundFlightId",
                        column: x => x.InboundFlightId,
                        principalTable: "InboundFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_OutboundFlights_OutboundFlightId",
                        column: x => x.OutboundFlightId,
                        principalTable: "OutboundFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "AircraftCabins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(nullable: false),
                    ZoneAlphaCapacity = table.Column<int>(nullable: false),
                    ZoneBravoCapacity = table.Column<int>(nullable: false),
                    ZoneCharlieCapacity = table.Column<int>(nullable: false),
                    ZoneDeltaCapacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftCabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftCabins_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContainerInfos_Messages_UniloadContainerMessageId",
                        column: x => x.UniloadContainerMessageId,
                        principalTable: "Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PaxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Nationality = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    PassportNumber = table.Column<string>(nullable: false),
                    AircraftCabinId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PaxId);
                    table.ForeignKey(
                        name: "FK_Passengers_AircraftCabins_AircraftCabinId",
                        column: x => x.AircraftCabinId,
                        principalTable: "AircraftCabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suitcases",
                columns: table => new
                {
                    SuitcaseId = table.Column<string>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    PaxId = table.Column<int>(nullable: false),
                    PassengerPaxId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suitcases", x => x.SuitcaseId);
                    table.ForeignKey(
                        name: "FK_Suitcases_Passengers_PassengerPaxId",
                        column: x => x.PassengerPaxId,
                        principalTable: "Passengers",
                        principalColumn: "PaxId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_OutboundFlightId",
                table: "Aircraft",
                column: "OutboundFlightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AircraftBaggageHolds_AircraftId",
                table: "AircraftBaggageHolds",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftCabins_AircraftId",
                table: "AircraftCabins",
                column: "AircraftId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArrivalMovements_InboundFlightId",
                table: "ArrivalMovements",
                column: "InboundFlightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_DepartureMovements_OutboundFlightId",
                table: "DepartureMovements",
                column: "OutboundFlightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FuelForms_AircraftId",
                table: "FuelForms",
                column: "AircraftId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_InboundFlightId",
                table: "Messages",
                column: "InboundFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_OutboundFlightId",
                table: "Messages",
                column: "OutboundFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_AircraftCabinId",
                table: "Passengers",
                column: "AircraftCabinId");

            migrationBuilder.CreateIndex(
                name: "IX_Suitcases_PassengerPaxId",
                table: "Suitcases",
                column: "PassengerPaxId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightForms_AircraftId",
                table: "WeightForms",
                column: "AircraftId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftBaggageHolds");

            migrationBuilder.DropTable(
                name: "ArrivalMovements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContainerInfos");

            migrationBuilder.DropTable(
                name: "DepartureMovements");

            migrationBuilder.DropTable(
                name: "FuelForms");

            migrationBuilder.DropTable(
                name: "Suitcases");

            migrationBuilder.DropTable(
                name: "WeightForms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "InboundFlights");

            migrationBuilder.DropTable(
                name: "AircraftCabins");

            migrationBuilder.DropTable(
                name: "Aircraft");

            migrationBuilder.DropTable(
                name: "OutboundFlights");
        }
    }
}
