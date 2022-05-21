using Microsoft.EntityFrameworkCore.Migrations;

namespace ErfanLearn.DataLayer.Migrations
{
    public partial class AddStatusToRolesMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Roles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Roles");
        }
    }
}
