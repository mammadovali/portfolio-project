using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class SocialMediaLinksInstagram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "İnstagramLink",
                table: "Abouts",
                newName: "InstagramLink");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InstagramLink",
                table: "Abouts",
                newName: "İnstagramLink");
        }
    }
}
