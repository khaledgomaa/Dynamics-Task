using Microsoft.EntityFrameworkCore.Migrations;

namespace Dynamics.Repository.Migrations
{
    public partial class UpdateStoresDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactNumber",
                table: "Stores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Stores",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Stores");
        }
    }
}
