namespace E_commerceTask.Models.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
