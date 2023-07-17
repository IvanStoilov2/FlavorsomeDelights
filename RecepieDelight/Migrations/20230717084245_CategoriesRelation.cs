using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecepieDelight.Migrations
{
    public partial class CategoriesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecepieId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_RecepieId",
                table: "Category",
                column: "RecepieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Recepie_RecepieId",
                table: "Category",
                column: "RecepieId",
                principalTable: "Recepie",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Recepie_RecepieId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_RecepieId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "RecepieId",
                table: "Category");
        }
    }
}
