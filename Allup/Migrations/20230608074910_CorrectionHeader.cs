using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allup.Migrations
{
    public partial class CorrectionHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Header_HeaderId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "HeaderId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Header_HeaderId",
                table: "Categories",
                column: "HeaderId",
                principalTable: "Header",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Header_HeaderId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "HeaderId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Header_HeaderId",
                table: "Categories",
                column: "HeaderId",
                principalTable: "Header",
                principalColumn: "Id");
        }
    }
}
