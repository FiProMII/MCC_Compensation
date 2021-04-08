using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class EditNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetailInformation",
                table: "TB_T_Approval",
                newName: "Note");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Note",
                table: "TB_T_Approval",
                newName: "DetailInformation");
        }
    }
}
