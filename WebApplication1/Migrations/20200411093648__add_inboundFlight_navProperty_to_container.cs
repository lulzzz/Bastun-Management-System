using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class _add_inboundFlight_navProperty_to_container : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OutboundFlightId",
                table: "Containers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InboundFlightId",
                table: "Containers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Containers_InboundFlightId",
                table: "Containers",
                column: "InboundFlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_InboundFlights_InboundFlightId",
                table: "Containers",
                column: "InboundFlightId",
                principalTable: "InboundFlights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_InboundFlights_InboundFlightId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_InboundFlightId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "InboundFlightId",
                table: "Containers");

            migrationBuilder.AlterColumn<int>(
                name: "OutboundFlightId",
                table: "Containers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
