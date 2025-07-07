using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // One category has many products
        public ICollection<Products> Products { get; set; }
    }
}
