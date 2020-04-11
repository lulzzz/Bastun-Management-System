using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class _update_containerInfoClass_allow_nulls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContainerId",
                table: "ContainerInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContainerId",
                table: "ContainerInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
