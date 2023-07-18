using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecepieDelight.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recepie",
                columns: new[] { "Id", "CategoryId", "Description", "Title", "complexity", "createdDate", "preparationTime" },
                values: new object[] { 3, 1, "qew", "bacon", 1, "2023-2-17", "2:30 min" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
