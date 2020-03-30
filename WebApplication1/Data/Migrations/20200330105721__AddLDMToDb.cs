using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _AddLDMToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoadDistributionMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightRef = table.Column<int>(nullable: false),
                    CrewConfiguration = table.Column<string>(nullable: true),
                    PAXMale = table.Column<int>(nullable: false),
                    PAXFemale = table.Column<int>(nullable: false),
                    PAXChildren = table.Column<int>(nullable: false),
                    PAXInfant = table.Column<int>(nullable: false),
                    TotalPayloadWeight = table.Column<int>(nullable: false),
                    PayloadPerCompartments = table.Column<string>(nullable: true),
                    TotalPAX = table.Column<int>(nullable: false),
                    TotalBags = table.Column<int>(nullable: false),
                    CargoWeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadDistributionMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadDistributionMessages_Flights_FlightRef",
                        column: x => x.FlightRef,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoadDistributionMessages_FlightRef",
                table: "LoadDistributionMessages",
                column: "FlightRef",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoadDistributionMessages");
        }
    }
}
