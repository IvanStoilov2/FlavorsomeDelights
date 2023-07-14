using RecepieDelight.Models;
using System.ComponentModel.DataAnnotations;

namespace RecepieDelight.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Filter { get; set; }

    }
}
