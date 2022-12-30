using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityCore.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CodesSet",
                table: "CodesSet");

            migrationBuilder.RenameTable(
                name: "CodesSet",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "CodesSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodesSet",
                table: "CodesSet",
                column: "Id");
        }
    }
}
