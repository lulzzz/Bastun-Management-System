using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class _update_db_remove_ucm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContainerInfos_Messages_UniloadContainerMessageId",
                table: "ContainerInfos");

            migrationBuilder.DropIndex(
                name: "IX_ContainerInfos_UniloadContainerMessageId",
                table: "ContainerInfos");

            migrationBuilder.DropColumn(
                name: "UniloadContainerMessageId",
                table: "ContainerInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniloadContainerMessageId",
                table: "ContainerInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContainerInfos_UniloadContainerMessageId",
                table: "ContainerInfos",
                column: "UniloadContainerMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContainerInfos_Messages_UniloadContainerMessageId",
                table: "ContainerInfos",
                column: "UniloadContainerMessageId",
                principalTable: "Messages",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
