using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSoCrud.Migrations
{
    public partial class UpdateStaffProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Staff_Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "Staff_Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearsOfExperience",
                table: "Staff_Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Staff_Members",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Staff_Members");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "Staff_Members");

            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "Staff_Members");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Staff_Members");
        }
    }
}
