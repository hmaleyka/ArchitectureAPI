using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.DAL.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "brands");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "brands",
                type: "bit",
                nullable: true);
        }
    }
}
