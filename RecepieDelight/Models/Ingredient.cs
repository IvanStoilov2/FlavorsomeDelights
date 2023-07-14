using RecepieDelight.Models;
using System.ComponentModel.DataAnnotations;

namespace RecepieDelight.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            this.Recepies = new HashSet<Recepie>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Filter { get; set; }

        public virtual ICollection<Recepie> Recepies { get; set; }

    }
}
