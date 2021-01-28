using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class TitleBrowser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitleOfBrowser",
                table: "Post",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleOfBrowser",
                table: "Post");
        }
    }
}
