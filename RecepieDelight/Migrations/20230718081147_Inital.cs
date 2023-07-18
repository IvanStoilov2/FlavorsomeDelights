using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecepieDelight.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shopping_Lists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopping_Lists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recepie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complexity = table.Column<int>(type: "int", nullable: false),
                    preparationTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recepie_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecepie",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    RecepiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecepie", x => new { x.IngredientsId, x.RecepiesId });
                    table.ForeignKey(
                        name: "FK_IngredientRecepie_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecepie_Recepie_RecepiesId",
                        column: x => x.RecepiesId,
                        principalTable: "Recepie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecepieShopping_List",
                columns: table => new
                {
                    RecepiesId = table.Column<int>(type: "int", nullable: false),
                    Shopping_ListsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecepieShopping_List", x => new { x.RecepiesId, x.Shopping_ListsId });
                    table.ForeignKey(
                        name: "FK_RecepieShopping_List_Recepie_RecepiesId",
                        column: x => x.RecepiesId,
                        principalTable: "Recepie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecepieShopping_List_shopping_Lists_Shopping_ListsId",
                        column: x => x.Shopping_ListsId,
                        principalTable: "shopping_Lists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecepie_RecepiesId",
                table: "IngredientRecepie",
                column: "RecepiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepie_CategoryId",
                table: "Recepie",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecepieShopping_List_Shopping_ListsId",
                table: "RecepieShopping_List",
                column: "Shopping_ListsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecepie");

            migrationBuilder.DropTable(
                name: "RecepieShopping_List");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recepie");

            migrationBuilder.DropTable(
                name: "shopping_Lists");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
