using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "IsAdmin", "IsValid", "Mail", "Password" },
                values: new object[] { 1, true, true, "John@Hotmail.com", "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1);
        }
    }
}
