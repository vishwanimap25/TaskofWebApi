using Microsoft.EntityFrameworkCore;
using MVCpracticewithVinesh.Models;

namespace MVCpracticewithVinesh.Db_context
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDBcontext()
        {
        }


        public DbSet<User> user { get; set; }
    }
}
