using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    public partial class BasketDetailChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BuyTotalPrice",
                table: "BasketDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "BasketDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyTotalPrice",
                table: "BasketDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "BasketDetails");
        }
    }
}
