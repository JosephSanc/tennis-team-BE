using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSoCrud.Migrations
{
    public partial class RemovesYearsOfExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "Staff_Members");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "YearsOfExperience",
                table: "Staff_Members",
                type: "float",
                nullable: true);
        }
    }
}
