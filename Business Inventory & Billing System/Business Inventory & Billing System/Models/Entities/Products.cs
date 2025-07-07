using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Entities
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }   //foregin key
        public Category Category { get; set; }  //navigation property

        public DateTime CreatedAt { get; set; }


        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
