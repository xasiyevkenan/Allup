using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allup.Migrations
{
    public partial class AddHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeaderId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Header",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Header", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_HeaderId",
                table: "Categories",
                column: "HeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Header_HeaderId",
                table: "Categories",
                column: "HeaderId",
                principalTable: "Header",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Header_HeaderId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Header");

            migrationBuilder.DropIndex(
                name: "IX_Categories_HeaderId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "HeaderId",
                table: "Categories");
        }
    }
}
