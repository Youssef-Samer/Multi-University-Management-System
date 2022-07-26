using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddUniversityNameInDEpartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacultyName",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniversityName",
                table: "Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyName",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "UniversityName",
                table: "Department");
        }
    }
}
