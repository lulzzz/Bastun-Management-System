using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class AddLoadingInstructionToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoadingInstructionId",
                table: "Flights",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoadingInstructions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutboundFlightId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    HoldOnePieces = table.Column<int>(nullable: true),
                    HoldTwoPieces = table.Column<int>(nullable: true),
                    HoldThreePieces = table.Column<int>(nullable: true),
                    HoldFourPieces = table.Column<int>(nullable: true),
                    HoldFivePieces = table.Column<int>(nullable: true),
                    HoldOneLeftContainerCount = table.Column<int>(nullable: true),
                    HoldOneRightContainerCount = table.Column<int>(nullable: true),
                    HoldTwoLeftContainerCount = table.Column<int>(nullable: true),
                    HoldTwoRightContainerCount = table.Column<int>(nullable: true),
                    HoldThreeLeftContainerCount = table.Column<int>(nullable: true),
                    HoldThreeRightContainerCount = table.Column<int>(nullable: true),
                    HoldFourLeftContainerCount = table.Column<int>(nullable: true),
                    HoldFourRightContainerCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadingInstructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadingInstructions_Flights_OutboundFlightId",
                        column: x => x.OutboundFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoadingInstructions_OutboundFlightId",
                table: "LoadingInstructions",
                column: "OutboundFlightId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoadingInstructions");

            migrationBuilder.DropColumn(
                name: "LoadingInstructionId",
                table: "Flights");
        }
    }
}
