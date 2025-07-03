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
    }
}
