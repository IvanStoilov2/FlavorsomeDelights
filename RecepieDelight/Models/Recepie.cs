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
            this.Shopping_Lists = new HashSet<Shopping_List>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created Date")]
        public string createdDate { get; set; }

        [Display(Name = "Complexity")]
        public int complexity { get; set; }

        [Display(Name = "Preparation Time")]
        public string preparationTime { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Shopping_List> Shopping_Lists{ get; set; }

        public virtual Category? Category { get; set; }

        public int CategoryId { get; set; }

       
    }
}
