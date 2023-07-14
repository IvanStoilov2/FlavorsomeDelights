using Microsoft.EntityFrameworkCore;
using RecepieDelight.Models;

namespace RecepieDelight.Data
{
    public class RecepieDelightContext : DbContext
    {
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
        }
    }
}
