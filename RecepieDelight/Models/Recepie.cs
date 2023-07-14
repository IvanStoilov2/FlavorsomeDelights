using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace RecepieDelight.Models
{
    public class Recepie
    {
        public Recepie()
        {
            this.Ingredients = new HashSet<Ingredient>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
