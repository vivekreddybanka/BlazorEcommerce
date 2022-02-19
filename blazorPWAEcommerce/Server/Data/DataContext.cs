

using Microsoft.EntityFrameworkCore;

namespace blazorPWAEcommerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
