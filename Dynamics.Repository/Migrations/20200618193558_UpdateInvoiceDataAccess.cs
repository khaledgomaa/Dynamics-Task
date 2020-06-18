using Microsoft.EntityFrameworkCore.Migrations;

namespace Dynamics.Repository.Migrations
{
    public partial class UpdateInvoiceDataAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Invoices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "Invoices",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
