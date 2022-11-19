using Microsoft.EntityFrameworkCore.Migrations;

namespace DataGridView1.Migrations
{
    public partial class AddSuck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Suck",
                table: "AbiturientsDB",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suck",
                table: "AbiturientsDB");
        }
    }
}
