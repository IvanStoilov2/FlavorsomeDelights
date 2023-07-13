using Microsoft.EntityFrameworkCore;

namespace RecepieDelight.Data
{
    public class RecepieDelightContext : DbContext
    {
        public RecepieDelightContext (DbContextOptions<RecepieDelightContext> options)
            : base(options)
        {
        }

        public DbSet<RecepieDelight.Models.Recepie> Recepie { get; set; } = default!;
        public DbSet<RecepieDelight.Models.Category> Category { get; set; } = default!;

    }
}
