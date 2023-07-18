using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecepieDelight.Migrations
{
    public partial class InitialDB : Migration
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" },
                    { 4, "Desserts" }
                });

            migrationBuilder.InsertData(
                table: "Recepie",
                columns: new[] { "Id", "CategoryId", "Description", "Title", "complexity", "createdDate", "preparationTime" },
                values: new object[,]
                {
                    { 1, 1, "A simple yet satisfying breakfast option featuring mashed avocado on whole-grain toast, topped with a sprinkle of salt, pepper, and red chili flakes.", "Classic Avocado Toast", 1, "2022-10-17", "12:30 min" },
                    { 2, 1, "Fluffy and delicious pancakes served with maple syrup and butter.", "Classic Pancakes", 1, "2022-11-13", "15:00 min" },
                    { 3, 1, "A protein-packed omelette loaded with sautéed vegetables like bell peppers, onions, and mushrooms.", "Veggie Omelette", 1, "2019-11-18", "09:00 min" },
                    { 4, 1, "Layered parfait with Greek yogurt, fresh berries, granola, and a drizzle of honey.", "Greek Yogurt Parfait", 1, "2020-07-06", "05:00 min" },
                    { 5, 1, "A filling breakfast wrapped in a tortilla, consisting of scrambled eggs, cheese, bacon or sausage, and optional toppings like salsa and avocado.", "Breakfast Burrito", 2, "2021-05-17", "25:00 min" },
                    { 6, 2, "A refreshing salad made with ripe tomatoes, fresh mozzarella, and basil leaves, drizzled with balsamic glaze.", "Caprese Salad", 1, "2020-01-25", "10:00 min" },
                    { 7, 2, "Grilled chicken, crisp romaine lettuce, and Caesar dressing wrapped in a tortilla for a quick and satisfying lunch.", "Chicken Caesar Wrap", 1, "2020-09-15", "15:00 min" },
                    { 8, 2, "Nutritious and flavorful salad featuring quinoa, roasted vegetables like sweet potatoes and bell peppers, and a zesty dressing.", "Quinoa Salad with Roasted Vegetables", 3, "2022-12-08", "30:00 min" },
                    { 9, 2, "A classic tuna salad mixture made with canned tuna, mayo, and diced vegetables, served between slices of bread or in a wrap.", "Tuna Salad Sandwich", 2, "2021-11-01", "10:00 min" },
                    { 10, 2, "A delicious blend of rice noodles, colorful vegetables, and a creamy peanut sauce with a hint of spice.", "Thai Peanut Noodles", 2, "2018-04-15", "25:00 min" },
                    { 11, 3, "Hearty pasta dish with a rich tomato-based meat sauce, served over spaghetti noodles.", "Spaghetti Bolognese", 3, "2021-01-28", "45:00 min" },
                    { 12, 3, "Tender and juicy roasted chicken marinated with lemon, garlic, and fresh herbs.", "Lemon Herb Roasted Chicken", 3, "2018-10-26", "55:00 min" },
                    { 13, 3, " Quick and flavorful stir-fried beef with a mix of colorful vegetables, served over steamed rice.", "Beef Stir-Fry", 1, "2019-03-16", "20:00 min" },
                    { 14, 3, " A fragrant and comforting curry loaded with seasonal vegetables, simmered in a spiced coconut milk sauce.", "Veggie Curry", 2, "2019-05-16", "40:00 min" },
                    { 15, 3, "Grilled salmon fillets served with tender roasted asparagus and a lemon-dill sauce.", "Grilled Salmon with Asparagus", 1, "2020-06-05", "30:00 min" },
                    { 16, 4, "Classic homemade cookies filled with chocolate chips, soft and chewy on the inside and crispy on the outside.", "Chocolate Chip Cookies", 1, "2020-03-05", "25:00 min" },
                    { 17, 4, "A warm and fruity dessert made with fresh berries, topped with a sweet and buttery crumble.", "Berry Crumble", 1, "2020-08-08", "40:00 min" },
                    { 18, 4, "An elegant Italian dessert made with layers of espresso-soaked ladyfingers and creamy mascarpone cheese.", "Tiramisu", 2, "2020-02-05", "30:00 min + chilling time" },
                    { 19, 4, " A classic American pie with a flaky crust and a sweet apple filling, spiced with cinnamon and nutmeg.", "Apple Pie", 3, "2019-12-29", "90:00 min" },
                    { 20, 4, "A refreshing and dairy-free frozen treat made with ripe mangoes, sugar, and a splash of lime juice.", "Mango Sorbet", 1, "2020-01-25", "15:00 min + freezing time" }
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
