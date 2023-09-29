using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    public partial class propertyEbilityChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Patients_PatientId",
                table: "Baskets");

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
    }
}
