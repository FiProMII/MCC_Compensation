using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class FixDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Document_TB_T_CompensationRequest_CompensationRequestRequestID",
                table: "TB_M_Document");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Approval_TB_T_CompensationRequest_CompensationRequestRequestID",
                table: "TB_T_Approval");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_EmployeeNIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_CompensationRequest_EmployeeNIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Approval_CompensationRequestRequestID",
                table: "TB_T_Approval");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_Document_CompensationRequestRequestID",
                table: "TB_M_Document");

            migrationBuilder.DropColumn(
                name: "EmployeeNIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.DropColumn(
                name: "CompensationRequestRequestID",
                table: "TB_T_Approval");

            migrationBuilder.DropColumn(
                name: "CompensationRequestRequestID",
                table: "TB_M_Document");

            migrationBuilder.AlterColumn<string>(
                name: "NIK",
                table: "TB_T_CompensationRequest",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_CompensationRequest_NIK",
                table: "TB_T_CompensationRequest",
                column: "NIK");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Approval_RequestID",
                table: "TB_T_Approval",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Document_RequestID",
                table: "TB_M_Document",
                column: "RequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Document_TB_T_CompensationRequest_RequestID",
                table: "TB_M_Document",
                column: "RequestID",
                principalTable: "TB_T_CompensationRequest",
                principalColumn: "RequestID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Approval_TB_T_CompensationRequest_RequestID",
                table: "TB_T_Approval",
                column: "RequestID",
                principalTable: "TB_T_CompensationRequest",
                principalColumn: "RequestID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_NIK",
                table: "TB_T_CompensationRequest",
                column: "NIK",
                principalTable: "TB_M_Employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Document_TB_T_CompensationRequest_RequestID",
                table: "TB_M_Document");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Approval_TB_T_CompensationRequest_RequestID",
                table: "TB_T_Approval");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_NIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_CompensationRequest_NIK",
                table: "TB_T_CompensationRequest");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Approval_RequestID",
                table: "TB_T_Approval");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_Document_RequestID",
                table: "TB_M_Document");

            migrationBuilder.AlterColumn<string>(
                name: "NIK",
                table: "TB_T_CompensationRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNIK",
                table: "TB_T_CompensationRequest",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompensationRequestRequestID",
                table: "TB_T_Approval",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompensationRequestRequestID",
                table: "TB_M_Document",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_CompensationRequest_EmployeeNIK",
                table: "TB_T_CompensationRequest",
                column: "EmployeeNIK");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Approval_CompensationRequestRequestID",
                table: "TB_T_Approval",
                column: "CompensationRequestRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Document_CompensationRequestRequestID",
                table: "TB_M_Document",
                column: "CompensationRequestRequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Document_TB_T_CompensationRequest_CompensationRequestRequestID",
                table: "TB_M_Document",
                column: "CompensationRequestRequestID",
                principalTable: "TB_T_CompensationRequest",
                principalColumn: "RequestID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Approval_TB_T_CompensationRequest_CompensationRequestRequestID",
                table: "TB_T_Approval",
                column: "CompensationRequestRequestID",
                principalTable: "TB_T_CompensationRequest",
                principalColumn: "RequestID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_CompensationRequest_TB_M_Employee_EmployeeNIK",
                table: "TB_T_CompensationRequest",
                column: "EmployeeNIK",
                principalTable: "TB_M_Employee",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
