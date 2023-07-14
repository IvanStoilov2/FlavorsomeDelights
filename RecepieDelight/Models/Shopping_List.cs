using System.ComponentModel.DataAnnotations;

namespace RecepieDelight.Models
{
    public class Shopping_List
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Recepie> Recepies { get; set; }

        public Shopping_List()
        {
            this.Recepies= new HashSet<Recepie>();
        }
    }
}
