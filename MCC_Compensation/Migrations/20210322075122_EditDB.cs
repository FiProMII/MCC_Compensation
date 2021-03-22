using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class EditDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Approval_TB_M_Department_DepartmentID",
                table: "TB_T_Approval");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Approval_DepartmentID",
                table: "TB_T_Approval");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "TB_T_Approval");

            migrationBuilder.AddColumn<string>(
                name: "NIK",
                table: "TB_T_Approval",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Approval_NIK",
                table: "TB_T_Approval",
                column: "NIK");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Approval_TB_M_Employee_NIK",
                table: "TB_T_Approval",
                column: "NIK",
                principalTable: "TB_M_Employee",
                principalColumn: "NIK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Approval_TB_M_Employee_NIK",
                table: "TB_T_Approval");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Approval_NIK",
                table: "TB_T_Approval");

            migrationBuilder.DropColumn(
                name: "NIK",
                table: "TB_T_Approval");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "TB_T_Approval",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Approval_DepartmentID",
                table: "TB_T_Approval",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Approval_TB_M_Department_DepartmentID",
                table: "TB_T_Approval",
                column: "DepartmentID",
                principalTable: "TB_M_Department",
                principalColumn: "DepartmentID");
        }
    }
}
