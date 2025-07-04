using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.AppDB
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDBcontext()
        {
        }

        //public DbSet<User> User { get; set; }

        public DbSet<User> User { get; set; }
    }
}
