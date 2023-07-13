using RecepieDelight.Models;
using System.ComponentModel.DataAnnotations;

namespace RecepieDelight.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
