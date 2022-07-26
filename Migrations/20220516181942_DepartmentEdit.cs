using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class DepartmentEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacultyId",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacultyName",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniversityId",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniversityName",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "FacultyName",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "UniversityName",
                table: "Course");
        }
    }
}
