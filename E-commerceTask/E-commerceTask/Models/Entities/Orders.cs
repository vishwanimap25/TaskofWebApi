using System.ComponentModel.DataAnnotations;

namespace E_commerceTask.Models.Entities
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderCategory{ get; set; }
        public string ProductName { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
