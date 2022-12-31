using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityCore.Migrations
{
    public partial class addInstok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStok",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStok",
                table: "Products");
        }
    }
}
