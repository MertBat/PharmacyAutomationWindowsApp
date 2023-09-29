using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    public partial class newProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "TC",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "TotalBuyPrice",
                table: "Baskets");

            migrationBuilder.AddColumn<bool>(
                name: "Coverage",
                table: "Medicines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Coverage",
                table: "Medicines");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TC",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalBuyPrice",
                table: "Baskets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId1",
                table: "Employees",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeId1",
                table: "Employees",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
