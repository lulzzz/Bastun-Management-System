using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class _Add_UCM_CPM_Container_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContainerPalletMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(nullable: false),
                    SupplementaryInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerPalletMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContainerPalletMessages_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(nullable: false),
                    ContainerPalletMessageId = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    ContainerNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_ContainerPalletMessages_ContainerPalletMessageId",
                        column: x => x.ContainerPalletMessageId,
                        principalTable: "ContainerPalletMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Containers_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContainerPalletMessages_FlightId",
                table: "ContainerPalletMessages",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerPalletMessageId",
                table: "Containers",
                column: "ContainerPalletMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_FlightId",
                table: "Containers",
                column: "FlightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "ContainerPalletMessages");
        }
    }
}
