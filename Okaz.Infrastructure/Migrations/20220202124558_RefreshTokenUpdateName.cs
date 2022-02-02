using Microsoft.EntityFrameworkCore.Migrations;

namespace Okaz.Infrastructure.Migrations
{
    public partial class RefreshTokenUpdateName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_ApplicationUsers_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshTokens",
                table: "RefreshTokens");

            migrationBuilder.RenameTable(
                name: "RefreshTokens",
                newName: "ApplicationRefreshTokens");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshTokens_UserId",
                table: "ApplicationRefreshTokens",
                newName: "IX_ApplicationRefreshTokens_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRefreshTokens",
                table: "ApplicationRefreshTokens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationRefreshTokens_ApplicationUsers_UserId",
                table: "ApplicationRefreshTokens",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRefreshTokens_ApplicationUsers_UserId",
                table: "ApplicationRefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRefreshTokens",
                table: "ApplicationRefreshTokens");

            migrationBuilder.RenameTable(
                name: "ApplicationRefreshTokens",
                newName: "RefreshTokens");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRefreshTokens_UserId",
                table: "RefreshTokens",
                newName: "IX_RefreshTokens_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshTokens",
                table: "RefreshTokens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_ApplicationUsers_UserId",
                table: "RefreshTokens",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
