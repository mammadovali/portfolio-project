using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class HardSkillSomePropsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "HardSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "HardSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "HardSkills");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "HardSkills");
        }
    }
}
