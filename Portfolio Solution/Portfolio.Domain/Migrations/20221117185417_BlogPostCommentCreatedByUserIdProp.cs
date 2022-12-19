using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class BlogPostCommentCreatedByUserIdProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId",
                table: "BlogPostComments");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "BlogPostComments",
                newName: "CreatedByUserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_CreatedByUserId",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_CreatedByUserIdId");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId1",
                table: "BlogPostComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_CreatedByUserId1",
                table: "BlogPostComments",
                column: "CreatedByUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId1",
                table: "BlogPostComments",
                column: "CreatedByUserId1",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserIdId",
                table: "BlogPostComments",
                column: "CreatedByUserIdId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId1",
                table: "BlogPostComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserIdId",
                table: "BlogPostComments");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostComments_CreatedByUserId1",
                table: "BlogPostComments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId1",
                table: "BlogPostComments");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserIdId",
                table: "BlogPostComments",
                newName: "CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostComments_CreatedByUserIdId",
                table: "BlogPostComments",
                newName: "IX_BlogPostComments_CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostComments_Users_CreatedByUserId",
                table: "BlogPostComments",
                column: "CreatedByUserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
