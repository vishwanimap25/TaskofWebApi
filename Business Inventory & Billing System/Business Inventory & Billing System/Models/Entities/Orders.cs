using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Entities
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation to Join Table
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
