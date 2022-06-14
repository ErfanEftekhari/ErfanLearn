using Microsoft.EntityFrameworkCore.Migrations;

namespace ErfanLearn.DataLayer.Migrations
{
    public partial class AddFieldToPermissionMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Permissions",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Permissions");
        }
    }
}
