using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSoCrud.Migrations
{
    public partial class AddStaffPropertyEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Staff_Members",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Staff_Members");
        }
    }
}
