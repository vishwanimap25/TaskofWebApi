using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Entities
{
    public class OrderItems
    {
        [Key]
        public int Id { get; set; }

        // Foreign Keys
        public int OrderId { get; set; }  //order
        public Orders Orders { get; set; }

        public int ProductId { get; set; }   //products
        public Products Products { get; set; }

        public int CategoryId { get; set; } //category
        public Category category { get; set; }

        // Additional Fields
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}


