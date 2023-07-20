﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecepieDelight.Data;

#nullable disable

namespace RecepieDelight.Migrations
{
    [DbContext(typeof(RecepieDelightContext))]
    partial class RecepieDelightContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IngredientRecepie", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("RecepiesId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "RecepiesId");

                    b.HasIndex("RecepiesId");

                    b.ToTable("IngredientRecepie");
                });

            modelBuilder.Entity("RecepieDelight.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dinner"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("RecepieDelight.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Filter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecepieDelight.Models.Recepie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("complexity")
                        .HasColumnType("int");

                    b.Property<string>("createdDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preparationTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recepie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A simple yet satisfying breakfast option featuring mashed avocado on whole-grain toast, topped with a sprinkle of salt, pepper, and red chili flakes.",
                            Title = "Classic Avocado Toast",
                            complexity = 1,
                            createdDate = "2022-10-17",
                            preparationTime = "12:30 min"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Fluffy and delicious pancakes served with maple syrup and butter.",
                            Title = "Classic Pancakes",
                            complexity = 1,
                            createdDate = "2022-11-13",
                            preparationTime = "15:00 min"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A protein-packed omelette loaded with sautéed vegetables like bell peppers, onions, and mushrooms.",
                            Title = "Veggie Omelette",
                            complexity = 1,
                            createdDate = "2019-11-18",
                            preparationTime = "09:00 min"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Layered parfait with Greek yogurt, fresh berries, granola, and a drizzle of honey.",
                            Title = "Greek Yogurt Parfait",
                            complexity = 1,
                            createdDate = "2020-07-06",
                            preparationTime = "05:00 min"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "A filling breakfast wrapped in a tortilla, consisting of scrambled eggs, cheese, bacon or sausage, and optional toppings like salsa and avocado.",
                            Title = "Breakfast Burrito",
                            complexity = 2,
                            createdDate = "2021-05-17",
                            preparationTime = "25:00 min"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "A refreshing salad made with ripe tomatoes, fresh mozzarella, and basil leaves, drizzled with balsamic glaze.",
                            Title = "Caprese Salad",
                            complexity = 1,
                            createdDate = "2020-01-25",
                            preparationTime = "10:00 min"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Grilled chicken, crisp romaine lettuce, and Caesar dressing wrapped in a tortilla for a quick and satisfying lunch.",
                            Title = "Chicken Caesar Wrap",
                            complexity = 1,
                            createdDate = "2020-09-15",
                            preparationTime = "15:00 min"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Nutritious and flavorful salad featuring quinoa, roasted vegetables like sweet potatoes and bell peppers, and a zesty dressing.",
                            Title = "Quinoa Salad with Roasted Vegetables",
                            complexity = 3,
                            createdDate = "2022-12-08",
                            preparationTime = "30:00 min"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "A classic tuna salad mixture made with canned tuna, mayo, and diced vegetables, served between slices of bread or in a wrap.",
                            Title = "Tuna Salad Sandwich",
                            complexity = 2,
                            createdDate = "2021-11-01",
                            preparationTime = "10:00 min"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "A delicious blend of rice noodles, colorful vegetables, and a creamy peanut sauce with a hint of spice.",
                            Title = "Thai Peanut Noodles",
                            complexity = 2,
                            createdDate = "2018-04-15",
                            preparationTime = "25:00 min"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Hearty pasta dish with a rich tomato-based meat sauce, served over spaghetti noodles.",
                            Title = "Spaghetti Bolognese",
                            complexity = 3,
                            createdDate = "2021-01-28",
                            preparationTime = "45:00 min"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Tender and juicy roasted chicken marinated with lemon, garlic, and fresh herbs.",
                            Title = "Lemon Herb Roasted Chicken",
                            complexity = 3,
                            createdDate = "2018-10-26",
                            preparationTime = "55:00 min"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = " Quick and flavorful stir-fried beef with a mix of colorful vegetables, served over steamed rice.",
                            Title = "Beef Stir-Fry",
                            complexity = 1,
                            createdDate = "2019-03-16",
                            preparationTime = "20:00 min"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = " A fragrant and comforting curry loaded with seasonal vegetables, simmered in a spiced coconut milk sauce.",
                            Title = "Veggie Curry",
                            complexity = 2,
                            createdDate = "2019-05-16",
                            preparationTime = "40:00 min"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Grilled salmon fillets served with tender roasted asparagus and a lemon-dill sauce.",
                            Title = "Grilled Salmon with Asparagus",
                            complexity = 1,
                            createdDate = "2020-06-05",
                            preparationTime = "30:00 min"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Description = "Classic homemade cookies filled with chocolate chips, soft and chewy on the inside and crispy on the outside.",
                            Title = "Chocolate Chip Cookies",
                            complexity = 1,
                            createdDate = "2020-03-05",
                            preparationTime = "25:00 min"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Description = "A warm and fruity dessert made with fresh berries, topped with a sweet and buttery crumble.",
                            Title = "Berry Crumble",
                            complexity = 1,
                            createdDate = "2020-08-08",
                            preparationTime = "40:00 min"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "An elegant Italian dessert made with layers of espresso-soaked ladyfingers and creamy mascarpone cheese.",
                            Title = "Tiramisu",
                            complexity = 2,
                            createdDate = "2020-02-05",
                            preparationTime = "30:00 min + chilling time"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = " A classic American pie with a flaky crust and a sweet apple filling, spiced with cinnamon and nutmeg.",
                            Title = "Apple Pie",
                            complexity = 3,
                            createdDate = "2019-12-29",
                            preparationTime = "90:00 min"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "A refreshing and dairy-free frozen treat made with ripe mangoes, sugar, and a splash of lime juice.",
                            Title = "Mango Sorbet",
                            complexity = 1,
                            createdDate = "2020-01-25",
                            preparationTime = "15:00 min + freezing time"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 1,
                            Description = "Fluffy scrambled eggs served with creamy avocado spread on crispy toast.",
                            Title = "Scrambled Eggs with Avocado Toast",
                            complexity = 1,
                            createdDate = "2020-02-05",
                            preparationTime = "10:00 min"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 1,
                            Description = "Shkembe soup is a traditional Bulgarian dish made with tripe (sheep or cow stomach) and is known for its unique flavors and hearty nature.",
                            Title = "Traditional Bulgarian Soup - Shkembe",
                            complexity = 3,
                            createdDate = "2020-04-23",
                            preparationTime = "120:00 min"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 1,
                            Description = "A flavorful and nutritious omelette filled with sautéed spinach and tangy feta cheese.",
                            Title = "Omelette with Spinach and Feta Cheese",
                            complexity = 2,
                            createdDate = "2020-11-28",
                            preparationTime = "13:00 min"
                        });
                });

            modelBuilder.Entity("RecepieDelight.Models.Shopping_List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("shopping_Lists");
                });

            modelBuilder.Entity("RecepieShopping_List", b =>
                {
                    b.Property<int>("RecepiesId")
                        .HasColumnType("int");

                    b.Property<int>("Shopping_ListsId")
                        .HasColumnType("int");

                    b.HasKey("RecepiesId", "Shopping_ListsId");

                    b.HasIndex("Shopping_ListsId");

                    b.ToTable("RecepieShopping_List");
                });

            modelBuilder.Entity("IngredientRecepie", b =>
                {
                    b.HasOne("RecepieDelight.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecepieDelight.Models.Recepie", null)
                        .WithMany()
                        .HasForeignKey("RecepiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecepieDelight.Models.Recepie", b =>
                {
                    b.HasOne("RecepieDelight.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RecepieShopping_List", b =>
                {
                    b.HasOne("RecepieDelight.Models.Recepie", null)
                        .WithMany()
                        .HasForeignKey("RecepiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecepieDelight.Models.Shopping_List", null)
                        .WithMany()
                        .HasForeignKey("Shopping_ListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
