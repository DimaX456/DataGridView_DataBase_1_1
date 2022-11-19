using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataGridView1.Migrations
{
    public partial class Pussy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbiturientsDB",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    FormaObychenia = table.Column<int>(nullable: false),
                    Matem = table.Column<decimal>(nullable: false),
                    Rus = table.Column<decimal>(nullable: false),
                    Inf = table.Column<decimal>(nullable: false),
                    Sum = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbiturientsDB", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbiturientsDB");
        }
    }
}
