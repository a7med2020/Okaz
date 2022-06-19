using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Okaz.Infrastructure.Migrations
{
    public partial class AddItemEnities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategory_CategoryID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemType_TypeID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemType",
                table: "ItemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategory",
                table: "ItemCategory");

            migrationBuilder.RenameTable(
                name: "ItemType",
                newName: "ItemTypes");

            migrationBuilder.RenameTable(
                name: "ItemCategory",
                newName: "ItemCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModefiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ItemTags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModefiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModefiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTags", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategories_CategoryID",
                table: "Items",
                column: "CategoryID",
                principalTable: "ItemCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemTypes_TypeID",
                table: "Items",
                column: "TypeID",
                principalTable: "ItemTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_CategoryID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemTypes_TypeID",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ItemTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories");

            migrationBuilder.RenameTable(
                name: "ItemTypes",
                newName: "ItemType");

            migrationBuilder.RenameTable(
                name: "ItemCategories",
                newName: "ItemCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemType",
                table: "ItemType",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategory",
                table: "ItemCategory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategory_CategoryID",
                table: "Items",
                column: "CategoryID",
                principalTable: "ItemCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemType_TypeID",
                table: "Items",
                column: "TypeID",
                principalTable: "ItemType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
