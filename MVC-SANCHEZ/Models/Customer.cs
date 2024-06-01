using System.ComponentModel.DataAnnotations;

namespace MVC_SANCHEZ.Models
{

    public class Customer
    {
        [Key]
        public int IdCustomers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
