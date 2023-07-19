using Microsoft.EntityFrameworkCore;
using RecepieDelight.Models;
using System.Reflection.Metadata;

namespace RecepieDelight.Data
{
    public class RecepieDelightContext : DbContext
    {
        public RecepieDelightContext()
        {
        }

        public RecepieDelightContext(DbContextOptions<RecepieDelightContext> options)
            : base(options) { }

        public DbSet<RecepieDelight.Models.Recepie> Recepie { get; set; } = default!;
        public DbSet<RecepieDelight.Models.Category> Category { get; set; } = default!;

        public DbSet<RecepieDelight.Models.Ingredient> Ingredients { get; set; } = default!;

        public DbSet<RecepieDelight.Models.Shopping_List> shopping_Lists { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Recepie>()
            //    .HasMany(r => r.Ingredients)
            //    .WithMany(i => i.Recepies)
            //    .UsingEntity(j => j.ToTable("RecepieIngredient")
            //    .HasData(new
            //        {
            //            RecepieID = 1,
            //            IngredientID = 1
            //        }
            //    ));

            base.OnModelCreating(modelBuilder);

            //SAMPLE OF SEEDING DATA
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Breakfast" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Lunch" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Dinner" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Desserts" });



            var recepie = new Recepie();
            recepie.Id = 1;
            recepie.Title = "Classic Avocado Toast";
            recepie.Description = "A simple yet satisfying breakfast option featuring mashed avocado on whole-grain toast, topped with a sprinkle of salt, pepper, and red chili flakes.";
            recepie.createdDate = "2022-10-17";
            recepie.complexity = 1;
            recepie.preparationTime = "12:30 min";
            recepie.CategoryId = 1;

            var recepie2 = new Recepie();
            recepie2.Id = 2;
            recepie2.Title = "Classic Pancakes";
            recepie2.Description = "Fluffy and delicious pancakes served with maple syrup and butter.";
            recepie2.createdDate = "2022-11-13";
            recepie2.complexity = 1;
            recepie2.preparationTime = "15:00 min";
            recepie2.CategoryId = 1;

            var recepie3 = new Recepie();
            recepie3.Id = 3;
            recepie3.Title = "Veggie Omelette";
            recepie3.Description = "A protein-packed omelette loaded with sautéed vegetables like bell peppers, onions, and mushrooms.";
            recepie3.createdDate = "2019-11-18";
            recepie3.complexity = 1;
            recepie3.preparationTime = "09:00 min";
            recepie3.CategoryId = 1;

            var recepie4 = new Recepie();
            recepie4.Id = 4;
            recepie4.Title = "Greek Yogurt Parfait";
            recepie4.Description = "Layered parfait with Greek yogurt, fresh berries, granola, and a drizzle of honey.";
            recepie4.createdDate = "2020-07-06";
            recepie4.complexity = 1;
            recepie4.preparationTime = "05:00 min";
            recepie4.CategoryId = 1;

            var recepie5 = new Recepie();
            recepie5.Id = 5;
            recepie5.Title = "Breakfast Burrito";
            recepie5.Description = "A filling breakfast wrapped in a tortilla, consisting of scrambled eggs, cheese, bacon or sausage, and optional toppings like salsa and avocado.";
            recepie5.createdDate = "2021-05-17";
            recepie5.complexity = 2;
            recepie5.preparationTime = "25:00 min";
            recepie5.CategoryId = 1;

            var recepie6 = new Recepie();
            recepie6.Id = 6;
            recepie6.Title = "Caprese Salad";
            recepie6.Description = "A refreshing salad made with ripe tomatoes, fresh mozzarella, and basil leaves, drizzled with balsamic glaze.";
            recepie6.createdDate = "2020-01-25";
            recepie6.complexity = 1;
            recepie6.preparationTime = "10:00 min";
            recepie6.CategoryId = 2;

            var recepie7 = new Recepie();
            recepie7.Id = 7;
            recepie7.Title = "Chicken Caesar Wrap";
            recepie7.Description = "Grilled chicken, crisp romaine lettuce, and Caesar dressing wrapped in a tortilla for a quick and satisfying lunch.";
            recepie7.createdDate = "2020-09-15";
            recepie7.complexity = 1;
            recepie7.preparationTime = "15:00 min";
            recepie7.CategoryId = 2;

            var recepie8 = new Recepie();
            recepie8.Id = 8;
            recepie8.Title = "Quinoa Salad with Roasted Vegetables";
            recepie8.Description = "Nutritious and flavorful salad featuring quinoa, roasted vegetables like sweet potatoes and bell peppers, and a zesty dressing.";
            recepie8.createdDate = "2022-12-08";
            recepie8.complexity = 3;
            recepie8.preparationTime = "30:00 min";
            recepie8.CategoryId = 2;

            var recepie9 = new Recepie();
            recepie9.Id = 9;
            recepie9.Title = "Tuna Salad Sandwich";
            recepie9.Description = "A classic tuna salad mixture made with canned tuna, mayo, and diced vegetables, served between slices of bread or in a wrap.";
            recepie9.createdDate = "2021-11-01";
            recepie9.complexity = 2;
            recepie9.preparationTime = "10:00 min";
            recepie9.CategoryId = 2;

            var recepie10 = new Recepie();
            recepie10.Id = 10;
            recepie10.Title = "Thai Peanut Noodles";
            recepie10.Description = "A delicious blend of rice noodles, colorful vegetables, and a creamy peanut sauce with a hint of spice.";
            recepie10.createdDate = "2018-04-15";
            recepie10.complexity = 2;
            recepie10.preparationTime = "25:00 min";
            recepie10.CategoryId = 2;

            var recepie11 = new Recepie();
            recepie11.Id = 11;
            recepie11.Title = "Spaghetti Bolognese";
            recepie11.Description = "Hearty pasta dish with a rich tomato-based meat sauce, served over spaghetti noodles.";
            recepie11.createdDate = "2021-01-28";
            recepie11.complexity = 3;
            recepie11.preparationTime = "45:00 min";
            recepie11.CategoryId = 3;

            var recepie12 = new Recepie();
            recepie12.Id = 12;
            recepie12.Title = "Lemon Herb Roasted Chicken";
            recepie12.Description = "Tender and juicy roasted chicken marinated with lemon, garlic, and fresh herbs.";
            recepie12.createdDate = "2018-10-26";
            recepie12.complexity = 3;
            recepie12.preparationTime = "55:00 min";
            recepie12.CategoryId = 3;

            var recepie13 = new Recepie();
            recepie13.Id = 13;
            recepie13.Title = "Beef Stir-Fry";
            recepie13.Description = " Quick and flavorful stir-fried beef with a mix of colorful vegetables, served over steamed rice.";
            recepie13.createdDate = "2019-03-16";
            recepie13.complexity = 1;
            recepie13.preparationTime = "20:00 min";
            recepie13.CategoryId = 3;

            var recepie14 = new Recepie();
            recepie14.Id = 14;
            recepie14.Title = "Veggie Curry";
            recepie14.Description = " A fragrant and comforting curry loaded with seasonal vegetables, simmered in a spiced coconut milk sauce.";
            recepie14.createdDate = "2019-05-16";
            recepie14.complexity = 2;
            recepie14.preparationTime = "40:00 min";
            recepie14.CategoryId = 3;

            var recepie15 = new Recepie();
            recepie15.Id = 15;
            recepie15.Title = "Grilled Salmon with Asparagus";
            recepie15.Description = "Grilled salmon fillets served with tender roasted asparagus and a lemon-dill sauce.";
            recepie15.createdDate = "2020-06-05";
            recepie15.complexity = 1;
            recepie15.preparationTime = "30:00 min";
            recepie15.CategoryId = 3;

            var recepie16 = new Recepie();
            recepie16.Id = 16;
            recepie16.Title = "Chocolate Chip Cookies";
            recepie16.Description = "Classic homemade cookies filled with chocolate chips, soft and chewy on the inside and crispy on the outside.";
            recepie16.createdDate = "2020-03-05";
            recepie16.complexity = 1;
            recepie16.preparationTime = "25:00 min";
            recepie16.CategoryId = 4;

            var recepie17 = new Recepie();
            recepie17.Id = 17;
            recepie17.Title = "Berry Crumble";
            recepie17.Description = "A warm and fruity dessert made with fresh berries, topped with a sweet and buttery crumble.";
            recepie17.createdDate = "2020-08-08";
            recepie17.complexity = 1;
            recepie17.preparationTime = "40:00 min";
            recepie17.CategoryId = 4;

            var recepie18 = new Recepie();
            recepie18.Id = 18;
            recepie18.Title = "Tiramisu";
            recepie18.Description = "An elegant Italian dessert made with layers of espresso-soaked ladyfingers and creamy mascarpone cheese.";
            recepie18.createdDate = "2020-02-05";
            recepie18.complexity = 2;
            recepie18.preparationTime = "30:00 min + chilling time";
            recepie18.CategoryId = 4;

            var recepie19 = new Recepie();
            recepie19.Id = 19;
            recepie19.Title = "Apple Pie";
            recepie19.Description = " A classic American pie with a flaky crust and a sweet apple filling, spiced with cinnamon and nutmeg.";
            recepie19.createdDate = "2019-12-29";
            recepie19.complexity = 3;
            recepie19.preparationTime = "90:00 min";
            recepie19.CategoryId = 4;

            var recepie20 = new Recepie();
            recepie20.Id = 20;
            recepie20.Title = "Mango Sorbet";
            recepie20.Description = "A refreshing and dairy-free frozen treat made with ripe mangoes, sugar, and a splash of lime juice.";
            recepie20.createdDate = "2020-01-25";
            recepie20.complexity = 1;
            recepie20.preparationTime = "15:00 min + freezing time";
            recepie20.CategoryId = 4;



            modelBuilder.Entity<Recepie>().HasData(recepie);
            modelBuilder.Entity<Recepie>().HasData(recepie2);
            modelBuilder.Entity<Recepie>().HasData(recepie3);
            modelBuilder.Entity<Recepie>().HasData(recepie4);
            modelBuilder.Entity<Recepie>().HasData(recepie5);

            modelBuilder.Entity<Recepie>().HasData(recepie6);
            modelBuilder.Entity<Recepie>().HasData(recepie7);
            modelBuilder.Entity<Recepie>().HasData(recepie8);
            modelBuilder.Entity<Recepie>().HasData(recepie9);
            modelBuilder.Entity<Recepie>().HasData(recepie10);

            modelBuilder.Entity<Recepie>().HasData(recepie11);
            modelBuilder.Entity<Recepie>().HasData(recepie12);
            modelBuilder.Entity<Recepie>().HasData(recepie13);
            modelBuilder.Entity<Recepie>().HasData(recepie14);
            modelBuilder.Entity<Recepie>().HasData(recepie15);

            modelBuilder.Entity<Recepie>().HasData(recepie16);
            modelBuilder.Entity<Recepie>().HasData(recepie17);
            modelBuilder.Entity<Recepie>().HasData(recepie18);
            modelBuilder.Entity<Recepie>().HasData(recepie19);
            modelBuilder.Entity<Recepie>().HasData(recepie20);
        }
    }
}
