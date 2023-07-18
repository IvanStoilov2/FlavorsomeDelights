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
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Category1" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Category2" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Category3" });



            var recepie = new Recepie();
            recepie.Id = 1;
            recepie.Title = "Classic Avocado Toast";
            recepie.Description = "agahweahah";
            recepie.createdDate = "2022-10-17";
            recepie.complexity = 1;
            recepie.preparationTime = "12:30 min";
            recepie.CategoryId = 1;

            var recepie2 = new Recepie();
            recepie2.Id = 2;
            recepie2.Title = "Eggs";
            recepie2.Description = "agahweahah";
            recepie2.createdDate = "2022-10-17";
            recepie2.complexity = 1;
            recepie2.preparationTime = "12:30 min";
            recepie2.CategoryId = 2;


            modelBuilder.Entity<Recepie>().HasData(recepie);
            modelBuilder.Entity<Recepie>().HasData(recepie2);





        }
    }
}
