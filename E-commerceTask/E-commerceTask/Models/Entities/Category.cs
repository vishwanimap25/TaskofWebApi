using System.ComponentModel.DataAnnotations;

namespace E_commerceTask.Models.Entities
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }

    }
}
