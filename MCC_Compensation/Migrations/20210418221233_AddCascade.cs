using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_NIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_NIK",
                table: "TB_T_CompensationRequest",
                column: "NIK",
                principalTable: "TB_M_Employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_NIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_NIK",
                table: "TB_T_CompensationRequest",
                column: "NIK",
                principalTable: "TB_M_Employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
