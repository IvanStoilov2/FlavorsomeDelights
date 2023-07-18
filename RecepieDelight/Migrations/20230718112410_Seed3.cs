using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecepieDelight.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A simple yet satisfying breakfast option featuring mashed avocado on whole-grain toast, topped with a sprinkle of salt, pepper, and red chili flakes.");

            migrationBuilder.UpdateData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Title", "createdDate", "preparationTime" },
                values: new object[] { 1, "Fluffy and delicious pancakes served with maple syrup and butter.", "Classic Pancakes", "2022-11-13", "15:00 min" });

            migrationBuilder.InsertData(
                table: "Recepie",
                columns: new[] { "Id", "CategoryId", "Description", "Title", "complexity", "createdDate", "preparationTime" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "agahweahah");

            migrationBuilder.UpdateData(
                table: "Recepie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Title", "createdDate", "preparationTime" },
                values: new object[] { 2, "agahweahah", "Eggs", "2022-10-17", "12:30 min" });
        }
    }
}
