using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Information",
                table: "TB_T_Approval");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "TB_T_Approval",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
