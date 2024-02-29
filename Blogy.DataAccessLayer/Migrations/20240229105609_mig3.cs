using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogy.DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Writers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArticleId1",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleId1",
                table: "Articles",
                column: "ArticleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Articles_ArticleId1",
                table: "Articles",
                column: "ArticleId1",
                principalTable: "Articles",
                principalColumn: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Articles_ArticleId1",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleId1",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "ArticleId1",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Articles");
        }
    }
}
