using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class AddPassengerAndSuitcaseClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    FlightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PaxId);
                    table.ForeignKey(
                        name: "FK_Passengers_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Passengers_FlightId",
                table: "Passengers",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Suitcases_PassengerPaxId",
                table: "Suitcases",
                column: "PassengerPaxId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suitcases");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}
