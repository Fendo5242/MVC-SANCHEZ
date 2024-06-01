using System.ComponentModel.DataAnnotations;

namespace MVC_SANCHEZ.Models
{
    public class Product
    {
        [Key]
        public int IdProducts { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

    }
}
