using System.ComponentModel.DataAnnotations;

namespace MVC_SANCHEZ.Models
{
    public class Detail
    {
        [Key]
        public int IdDetails { get; set; }
        public int Products_IdProducts { get; set; }
        public int Invoices_IdInvoices { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }

        public Product Product { get; set; }
        public Invoice Invoice { get; set; }
    }
}
