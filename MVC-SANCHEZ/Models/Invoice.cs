using System.ComponentModel.DataAnnotations;

namespace MVC_SANCHEZ.Models
{
    public class Invoice
    {
        [Key]
        public int IdInvoices { get; set; }
        public int Customers_IdCustomers { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Detail> Details { get; set; }
    }

}
