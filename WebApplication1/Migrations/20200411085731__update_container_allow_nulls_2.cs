using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Migrations
{
    public partial class _update_container_allow_nulls_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                 name: "ContainerId",
                 table: "Containers",
                 nullable: true,
                 oldClrType: typeof(int),
                 oldType: "int");
               
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
