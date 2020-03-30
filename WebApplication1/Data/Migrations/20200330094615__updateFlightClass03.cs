using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _updateFlightClass03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Flights",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Flights",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.CreateTable(
                name: "Passenger",
                columns: table => new
                {
                    PaxId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Nationality = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PassportNumber = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    FlightId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.PaxId);
                    table.ForeignKey(
                        name: "FK_Passenger_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suitcase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<double>(nullable: false),
                    PassengerPaxId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suitcase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suitcase_Passenger_PassengerPaxId",
                        column: x => x.PassengerPaxId,
                        principalTable: "Passenger",
                        principalColumn: "PaxId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passenger_FlightId",
                table: "Passenger",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Suitcase_PassengerPaxId",
                table: "Suitcase",
                column: "PassengerPaxId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suitcase");

            migrationBuilder.DropTable(
                name: "Passenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Flights");

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Flights",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightNumber");
        }
    }
}
