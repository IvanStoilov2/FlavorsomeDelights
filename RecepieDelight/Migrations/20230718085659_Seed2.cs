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
                values: new object[] { 2, 2, "agahweahah", "Eggs", 1, "2022-10-17", "12:30 min" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
