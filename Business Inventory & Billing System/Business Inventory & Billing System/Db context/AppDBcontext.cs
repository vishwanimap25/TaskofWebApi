using Business_Inventory___Billing_System.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business_Inventory___Billing_System.Db_context
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions options) : base(options)
        {
        }
      
        protected AppDBcontext()
        {
        }


        public DbSet<Customers> Customers { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<SalesReport> SalesReports { get; set; }
        public DbSet<Users> Users { get; set; }


    }
}
