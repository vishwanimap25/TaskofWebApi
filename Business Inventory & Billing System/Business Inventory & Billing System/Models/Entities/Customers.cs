using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Entities
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MobileNo { get; set; }
        public int Borrowings { get; set; }

    }
}
